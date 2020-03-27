using OrderLibrary;
using OrderLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderUI
{
    public partial class OrderDashBoard : Form
    {
        List<TableModel> availableTables = GlobalConfig.Connection.GetTable_All();
        int selectedTable;

        public OrderDashBoard()
        {
            InitializeComponent();

            WireUpDropDown();
        }



        private void WireUpDropDown()
        {
            loadOrderByTableDropDown.DataSource = null;
            loadOrderByTableDropDown.DataSource = availableTables;
            loadOrderByTableDropDown.DisplayMember = "TableNumber";
        }


        private void loadOrderByTableDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTable = ((TableModel)loadOrderByTableDropDown.SelectedItem).TableNumber;
        }



        private void loadOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                OrderViewerForm form = new OrderViewerForm(selectedTable);
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show($"There is no order for Table { selectedTable }!");
                return;
            }
        }



        private void createOrderButton_Click(object sender, EventArgs e)
        {
            CreateOrderForm form = new CreateOrderForm();
            form.Show();
        }
    }
}

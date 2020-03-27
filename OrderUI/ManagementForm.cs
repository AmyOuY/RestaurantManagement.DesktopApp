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
    public partial class ManagementForm : Form
    {
        public ManagementForm()
        {
            InitializeComponent();
        }



        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderDashBoard dashBoard = new OrderDashBoard();
            dashBoard.Show();
        }



        private void foodButton_Click(object sender, EventArgs e)
        {
            FoodViewerForm form = new FoodViewerForm();
            form.Show();
        }



        private void tableButton_Click(object sender, EventArgs e)
        {
            TableViewerForm form = new TableViewerForm();
            form.Show();
        }



        private void attendantButton_Click(object sender, EventArgs e)
        {
            AttendantViewerForm form = new AttendantViewerForm();
            form.Show();
        }
    }
}

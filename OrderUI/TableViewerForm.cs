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
    public partial class TableViewerForm : Form
    {
        public TableViewerForm()
        {
            InitializeComponent();
        }


        private void createTableButton_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                TableModel t = new TableModel();
                t.TableNumber = int.Parse(tableNumberValue.Text);
                t.Seats = int.Parse(seatsValue.Text);

                GlobalConfig.Connection.CreateTable(t);

                tableNumberValue.Text = "";
                seatsValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all fields!");
            }
        }



        private bool IsValidForm()
        {
            int tableNumber = 0;
            if (!int.TryParse(tableNumberValue.Text, out tableNumber))
            {
                return false;
            }

            List<TableModel> allTables = GlobalConfig.Connection.GetTable_All();
            foreach (TableModel t in allTables)
            {
                if (t.TableNumber == tableNumber)
                {
                    MessageBox.Show("Table Number already exists, please try a new number!");
                    return false;
                }
            }

            int seats = 0;
            if (!int.TryParse(seatsValue.Text, out seats))
            {
                return false;
            }

            return true;
        }
    }
}

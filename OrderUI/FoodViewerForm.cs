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
    public partial class FoodViewerForm : Form
    {
        public FoodViewerForm()
        {
            InitializeComponent();
        }


        private void createFoodButton_Click(object sender, EventArgs e)
        {
            if (IsValidFood())
            {
                FoodModel f = new FoodModel();
                f.FoodType = foodTypeValue.Text;
                f.FoodName = foodNameValue.Text;
                f.Price = decimal.Parse(priceValue.Text);

                GlobalConfig.Connection.CreateFood(f);

                foodTypeValue.Text = "";
                foodNameValue.Text = "";
                priceValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all fields!");
            }
        }


        private bool IsValidFood()
        {
            if (foodTypeValue.Text.Length == 0)
            {
                return false;
            }

            if (foodNameValue.Text.Length == 0)
            {
                return false;
            }

            decimal price = 0;
            if (!decimal.TryParse(priceValue.Text, out price))
            {
                return false;
            }

            return true;
        }
    }
}

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
    public partial class CreateOrderForm : Form
    {
        private List<TableModel> availableTables = GlobalConfig.Connection.GetTable_All();
        private List<PersonModel> availableAttendants = GlobalConfig.Connection.GetAttendant_All();
        private List<string> availableFoodType = GlobalConfig.Connection.GetFoodType_All();
        private List<FoodModel> availableFoodByType = new List<FoodModel>();
        private decimal foodPrice;
        private List<FoodModel> selectedFood= new List<FoodModel>();
        private PersonModel chef = GlobalConfig.Connection.GetChef();

        public CreateOrderForm()
        {
            InitializeComponent();

            WireUpDropDowns();          
        }



        private void orderByTableDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        public void WireUpDropDowns()
        {
            orderByTableDropDown.DataSource = null;
            orderByTableDropDown.DataSource = availableTables;
            orderByTableDropDown.DisplayMember = "TableNumber";

            attendantDropDown.DataSource = null;
            attendantDropDown.DataSource = availableAttendants;
            attendantDropDown.DisplayMember = "FullName";

            foodTypeDropDown.DataSource = null;
            foodTypeDropDown.DataSource = availableFoodType;
            foodTypeDropDown.DisplayMember = "FoodType";

            foodNameDropDown.DataSource = null;
            foodNameDropDown.DataSource = availableFoodByType;
            foodNameDropDown.DisplayMember = "FoodName";
        }



        public void WireUpListBox()
        {
            selectedFoodListBox.DataSource = null;
            selectedFoodListBox.DataSource = selectedFood;
            selectedFoodListBox.DisplayMember = "OrderedFood";
        }


        private void GetFoodByType(string type)
        {         
            availableFoodByType = GlobalConfig.Connection.GetFood_ByType(type);
        }




        private void LoadFood()
        {
            foodNameDropDown.DataSource = availableFoodByType;
            foodNameDropDown.DisplayMember = "FoodName";
        }



        private void LoadPrice()
        {
            FoodModel food = (FoodModel)foodNameDropDown.SelectedItem;
            foodPrice = GlobalConfig.Connection.GetFoodPrice(food);
            priceValue.Text = Convert.ToString(foodPrice);
        }


     

        private void foodTypeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFoodByType((string)foodTypeDropDown.SelectedItem);

            LoadFood();
        }



        private void foodNameDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (foodNameDropDown.SelectedItem != null)
            {
                LoadPrice();
            }           
        }



        private void selectFoodButton_Click(object sender, EventArgs e)
        {
            string foodName = foodNameDropDown.Text;
            FoodModel existingFood = selectedFood.Where(x => x.FoodName == foodName).FirstOrDefault();

            if (existingFood != null)
            {
                existingFood.Quantity += int.Parse(quantityValue.Text);
            }
            else
            {
                FoodModel f = new FoodModel();
                f.FoodType = foodTypeDropDown.Text;
                f.FoodName = foodNameDropDown.Text;
                f.Price = decimal.Parse(priceValue.Text);
                f.Quantity = int.Parse(quantityValue.Text);
                selectedFood.Add(f); 
            }

            WireUpListBox();           
        }



        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            FoodModel f = (FoodModel)selectedFoodListBox.SelectedItem;

            if (f != null)
            {
                selectedFood.Remove(f);

                WireUpListBox();
            }
        }




        private void createOrderButton_Click(object sender, EventArgs e)
        {
            OrderModel o = new OrderModel();

            o.TableNumber = ((TableModel)orderByTableDropDown.SelectedItem).TableNumber;
            o.Attendant = ((PersonModel)attendantDropDown.SelectedItem).FullName;
            o.FoodOrdered = selectedFood;

            GlobalConfig.Connection.CreateOrder(o);

            SendOrderToChef(o);
        }



        private void SendOrderToChef(OrderModel o)
        {
            string to = chef.EmailAddress;
            string subject = "New Order";

            StringBuilder body = new StringBuilder();
            body.AppendLine("<h1>You have a new order</h1>");       
            body.AppendLine($"<br><strong>Table: { o.TableNumber }</strong></br>");
            body.AppendLine($"<br><strong>Attendant: { o.Attendant }</strong></br>");
            body.AppendLine("...............................................................");

            foreach (FoodModel f in o.FoodOrdered)
            {
                body.Append($"<br><strong>{ f.FoodName }:  { f.Quantity }</stong></br>");
            }

            EmailLogic.SendEmail(to, subject, body.ToString());
        }
    }
}

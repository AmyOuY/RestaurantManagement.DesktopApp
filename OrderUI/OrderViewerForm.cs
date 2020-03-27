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
    public partial class OrderViewerForm : Form
    {
        private int tableNumber;
        private OrderModel order;
        private decimal subTotal;
        private const float TaxRatio = 0.15f;
        private decimal tax;
        private decimal total;


        public OrderViewerForm(int tableNo)
        {
            InitializeComponent();

            tableNumber = tableNo;

            LoadOrder();
        }

        

        private void LoadOrder()
        {
            order = GlobalConfig.Connection.GetOrder_ByTable(tableNumber);

            orderByTableValue.Text = (order.TableNumber).ToString();
            attendantValue.Text = order.Attendant;

            orderedFoodListBox.DataSource = null;
            orderedFoodListBox.DataSource = order.FoodOrdered;
            orderedFoodListBox.DisplayMember = "OrderedFood";

            foreach (FoodModel f in order.FoodOrdered)
            {
                subTotal += f.Price * f.Quantity;
            }

            subtotalValue.Text = subTotal.ToString();

            tax = subTotal * (decimal)TaxRatio;
            taxValue.Text = tax.ToString();

            total = subTotal + tax;
            totalValue.Text = total.ToString();
        }



        private void SendBillToAttendant(OrderModel o)
        {
            string to = (GlobalConfig.Connection.GetPersonByFullName(o.Attendant)).EmailAddress;
            string subject = "Bill";

            StringBuilder body = new StringBuilder();
            body.AppendLine($"<h1>{ o.Attendant }, A bill is ready to pay</h1>");
            body.AppendLine($"<br><strong>Table: { o.TableNumber }</strong></br>");
            body.AppendLine(".......................................................................");

            foreach (FoodModel f in o.FoodOrdered)
            {
                body.Append($"<br><strong>{ f.FoodName }: { f.Price } x { f.Quantity }</stong></br>");
            }

            body.AppendLine(".......................................................................");

            body.Append($"<br><strong>Subtotal: { subTotal }</strong></br>");
            body.Append($"<br><strong>Tax: { tax }</strong></br>");
            body.Append($"<br><strong>Total: { total }</strong></br>");

            EmailLogic.SendEmail(to, subject, body.ToString());
        }



        private void payBillButton_Click(object sender, EventArgs e)
        {
            SendBillToAttendant(order);
        }
    }
}

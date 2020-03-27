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
    public partial class AttendantViewerForm : Form
    {
        public AttendantViewerForm()
        {
            InitializeComponent();
        }


        private void createAttendantButton_Click(object sender, EventArgs e)
        {
            if (IsValidForm())
            {
                PersonModel p = new PersonModel();
                p.EmployeeID = int.Parse(employeeIDValue.Text);
                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellPhoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);

                employeeIDValue.Text = "";
                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all the fields!");
            }
        }


        private bool IsValidForm()
        {
            int id = 0;
            if (!int.TryParse(employeeIDValue.Text, out id))
            {
                return false;
            }

            List<PersonModel> allAttendants = GlobalConfig.Connection.GetAttendant_All();
            foreach (PersonModel p in allAttendants)
            {
                if (p.EmployeeID == id)
                {
                    MessageBox.Show("Employee ID already exists, please enter a new one!");
                    return false;
                }
            }

            if (firstNameValue.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellPhoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}

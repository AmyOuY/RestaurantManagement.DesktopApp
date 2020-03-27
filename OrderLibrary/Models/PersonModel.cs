using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person in database
        /// </summary>
        public int Id { get; set; }

        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string CellphoneNumber { get; set; }


        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}

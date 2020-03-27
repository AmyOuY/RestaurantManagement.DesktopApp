using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Models
{
    public class OrderModel
    {
        /// <summary>
        /// The unique identifier for the order
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The table that placed the order
        /// </summary>
        public int TableNumber { get; set; }

        /// <summary>
        /// The attendant that serves the order
        /// </summary>
        public string Attendant { get; set; }

        /// <summary>
        /// The list of food that ordered 
        /// </summary>
        public List<FoodModel> FoodOrdered { get; set; }
    }
}

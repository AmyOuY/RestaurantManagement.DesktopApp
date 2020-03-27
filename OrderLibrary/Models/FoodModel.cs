using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Models
{
    public class FoodModel
    {
        /// <summary>
        /// The unique identifier for the food
        /// </summary>
        public int Id { get; set; }
       
        /// <summary>
        /// The category of the food 
        /// </summary>
        public string FoodType { get; set; }

        /// <summary>
        /// The name of the food
        /// </summary>
        public string FoodName { get; set; }

        /// <summary>
        /// The price of the food
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// The quantity of the food ordered
        /// </summary>
        public int Quantity { get; set; }


        /// <summary>
        /// the unique identifier of order that contains this food
        /// </summary>
        public int OrderID { get; set; }



        public string OrderedFood
        {
            get
            {
                return $"{ FoodName }      { Price }      {Quantity }";
            }      
        }
    }
}

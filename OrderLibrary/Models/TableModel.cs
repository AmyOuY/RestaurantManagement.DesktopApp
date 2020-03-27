using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.Models
{
    public class TableModel
    {
        /// <summary>
        /// The unique identifier of the table
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The number of table
        /// </summary>
        public int TableNumber { get; set; }

        /// <summary>
        /// Capacity of the table
        /// </summary>
        public int Seats { get; set; }

    }
}

using OrderLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreateFood(FoodModel model);
        void CreatePerson(PersonModel model);
        void CreateTable(TableModel model);
        void CreateOrder(OrderModel model);

        List<TableModel> GetTable_All();
        List<PersonModel> GetAttendant_All();
        List<FoodModel> GetFood_All();
        List<string> GetFoodType_All();
        List<FoodModel> GetFood_ByType(string type);
        List<OrderModel> GetOrder_All();
        OrderModel GetOrder_ByTable(int tableNumber);
        decimal GetFoodPrice(FoodModel model);
        PersonModel GetChef();
        PersonModel GetPersonByFullName(string name);
    }
}

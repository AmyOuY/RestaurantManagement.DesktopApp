using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using OrderLibrary.Models;

namespace OrderLibrary.DataAccess
{
    public class SqlConnection : IDataConnection
    {
        private const string db = "Orders";

        public void CreateFood(FoodModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FoodType", model.FoodType);
                p.Add("@FoodName", model.FoodName);               
                p.Add("@Price", model.Price);
                p.Add("@Quantity", model.Quantity);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spFood_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("id");                
            }
        }



        public void CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("EmployeeID", model.EmployeeID);
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }




        public void CreateTable(TableModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TableNumber", model.TableNumber);
                p.Add("@Seats", model.Seats);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTable_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("id");
            }
        }



        public void CreateOrder(OrderModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TableNumber", model.TableNumber);
                p.Add("@Attendant", model.Attendant);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spOrders_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach (FoodModel food in model.FoodOrdered)
                {
                    p = new DynamicParameters();
                    p.Add("OrderId", model.Id);
                    p.Add("@FoodType", food.FoodType);
                    p.Add("@FoodName", food.FoodName);
                    p.Add("@Price", food.Price);
                    p.Add("@Quantity", food.Quantity);
                    connection.Execute("dbo.spOrderFood_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }



        public List<PersonModel> GetAttendant_All()
        {
            List<PersonModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }

            return output;
        }



        public List<TableModel> GetTable_All()
        {
            List<TableModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<TableModel>("dbo.spTable_GetAll").ToList();
            }

            return output;
        }



        public List<FoodModel> GetFood_All()
        {
            List<FoodModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<FoodModel>("dbo.spFood_GetAll").ToList();
            }

            return output;
        }



        public List<string> GetFoodType_All()
        {
            List<string> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<string>("dbo.spFoodType_GetAll").ToList();
            }

            return output;
        }



        public List<FoodModel> GetFood_ByType(string type)
        {
            List<FoodModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@type", type);

                output = connection.Query<FoodModel>("dbo.spFood_GetByType", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }




        public List<OrderModel> GetOrder_All()
        {
            List<OrderModel> output;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<OrderModel>("dbo.spOrder_GetAll").ToList();

            }

            return output;
        }




        public OrderModel GetOrder_ByTable(int tableNumber)
        {
            List<OrderModel> allOrders = GetOrder_All();

            allOrders = allOrders.OrderByDescending(x => x.Id).ToList();

            OrderModel output = allOrders.Where(x => x.TableNumber == tableNumber).First();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("OrderID", output.Id);

                output.FoodOrdered = connection.Query<FoodModel>("dbo.spFood_GetByOrder", p, commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }



        public decimal GetFoodPrice(FoodModel food)
        {
            FoodModel output;

            List<FoodModel> allFood = GetFood_All();


            output = allFood.Where(x => x.FoodName == food.FoodName).First();

            return output.Price;
        }



        public PersonModel GetChef()
        {
            PersonModel output;

            List<PersonModel> attendants = GetAttendant_All();

            output = attendants.Where(x => x.EmployeeID == 0).First();

            return output;
        }



        public PersonModel GetPersonByFullName(string name)
        {
            PersonModel person;

            List<PersonModel> attendants = GetAttendant_All();

            person = attendants.Where(x => x.FullName == name).First();

            return person;
        }
    }
}

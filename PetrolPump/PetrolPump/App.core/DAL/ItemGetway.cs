using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using patrolPumpApp.Models;

namespace PetrolPump.App.core.DAL
{
    public class ItemGetway
    {
        private string connectionString =
            "Data Source=192.168.0.103,49170;Initial Catalog=patrolPump;User=sa; Password=123;";


        public List<Item> GETALL()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Item";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Item> items = new List<Item>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var item = new Item();
                    item.Id = Convert.ToInt32(reader["Id"]);
                    item.ItemId = reader["item_id"].ToString();
                    item.Name = reader["name"].ToString();
                    item.Price = Convert.ToDouble(reader["price"]);
                    items.Add(item);
                }

            }

            connection.Close();
            return items;
        }
    }
}
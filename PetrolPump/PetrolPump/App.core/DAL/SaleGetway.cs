using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using patrolPumpApp.Models;

namespace patrolPumpApp.App.core.DAL
{
    public class SaleGetway
    {
        private string connectionString = "Data Source=192.168.0.103,49170;Initial Catalog=patrolPump;User=sa; Password=123;";

   
             public bool Save(Sale sale)
              {
            bool isSave = false;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
                  string query = "INSERT INTO Sales(car_no,item_id,unit,amount,sale_date)" +
                                 "VALUES('"+sale.CarNo+"','"+sale.Item.ItemId+"','"+sale.Unit+"','"+sale.Amount+"','"+sale.SellDate.ToString("MM/dd/yyyy HH:mm:ss")+"') ";
            SqlCommand command = new SqlCommand(query, connection);
            int rowsEffected = command.ExecuteNonQuery();

            if (rowsEffected > 0)
            {
                isSave = true;
            }
            connection.Close();
            return isSave;
        }
        }

    }

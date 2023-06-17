using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class AccountScheduleRepository : RepositoryBase<AccountSchedule>
    {
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:POSDB"];
            return strConn;
        }
        public void updateAccountSchedule(AccountSchedule acc, int schedule_id)
        {
            SqlConnection connect = new SqlConnection(GetConnectionString());


            // Connect to database.
            connect.Open();

            // Query parameters.
            int account_id = acc.AccountId;
            int schedule_idCRUD = acc.ScheduleId;

            // Query text.
            string sqlText = @"
        UPDATE AccountSchedule 
        SET schedule_id = @schedule_id
        WHERE account_id = @account_id and schedule_id = @schedule_idCRUD
    ";

            // Query text incorporated into SQL command.
            SqlCommand sqlUpdate = new SqlCommand(sqlText, connect);

            // Bind the parameters to the query.
            sqlUpdate.Parameters.AddWithValue("@schedule_id", schedule_id);
            sqlUpdate.Parameters.AddWithValue("@schedule_idCRUD", schedule_idCRUD);
            sqlUpdate.Parameters.AddWithValue("@account_id", account_id);

            // Execute SQL.
            sqlUpdate.ExecuteNonQuery();

            // Close the database connection.
            connect.Close();



        }
    }
}

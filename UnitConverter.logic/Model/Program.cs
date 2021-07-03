using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;

namespace UnitConverter.logic.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayDataUsingEF();
        }

        private static void DisplayDataUsingEF()
        {
            using (JippDBContext context = new JippDBContext())
            {
                List<Statistics> statistics = context.Statistics.ToList();

                foreach (Statistics s in statistics)
                {
                    Console.WriteLine(s.ID + " " + s.InputUnit + " " + s.OutputUnit + " " + s.Value);
                }
            }
        }

       /* public static void DisplayDataUsingADONET()
        {
            using (SqlConnection connection =
                new SqlConnection("Data Source=.\\MSSQLSERVER;Initial Catalog=JippDB;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Statistics", connection);
                IDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader["ID"] + " " +reader["Measure"] + " " + reader["InputUnit"] + " " + reader["OutputUnit"]
                        + " " + reader["Value"] + reader["Output"]);
                }
            }
        }*/
    }
}

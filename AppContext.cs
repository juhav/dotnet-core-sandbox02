using System;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace ConsoleApplication
{
    public class AppContext : ConsoleContext
    {
        public AppContext() : base()
        {
            MyDbContext.Initialize(this.DefaultConnectionString);
            Console.WriteLine(this.DefaultConnectionString);
        }

        public void Run()
        {
            using (var db = MyDbContext.Create())
            {
                var rows = db.Configuration.AsNoTracking().ToList();

                foreach (var row in rows)
                {
                    Console.WriteLine("{0}={1}", row.Key, row.Value);
                }

                // db.Configuration.Add(new Configuration() {
                //     Key = "test2",
                //     Value = "value2"
                // });

                db.Configuration.First().Value = DateTime.Now.ToString("yyyyMMdd HH:mm:ss");

                db.SaveChanges();
            }
        }

        private void TestClassicSql()
        {
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=postgres;Database=test"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;

                    // Retrieve all rows
                    cmd.CommandText = "SELECT * FROM core_configuration";
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.Write(reader.GetString(0));
                            Console.Write("=");
                            Console.WriteLine(reader.GetString(1));
                        }
                    }
                }
            }
        }
    }
}
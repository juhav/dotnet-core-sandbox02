using System;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new AppContext();
            app.Run();
        }


    }
}

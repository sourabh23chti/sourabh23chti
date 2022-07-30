using ConsoleApplication1.Command;
using ConsoleApplication1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class a
    {
        public a():this(5)
        {
           
        }
        public a(int x)
        {
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
try
{
            var command = new CommandRepository(new WriteCommand());
            command.SaveMyData();
            var query = new QueriesRepository(new Queries.Queries());
            query.GetMyData();
}
catch(Exception ex)
{
}
        }
    }
}

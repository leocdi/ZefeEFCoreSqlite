using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<ARTICLE>();
            var articles2 = new List<ARTICLE>();

            for (int i = 0; i < 35000; i++)
            {
                articles.Add(new ARTICLE());
            }

            for (int i = 0; i < 35000; i++)
            {
                articles2.Add(new ARTICLE());
            }

            var sw = new Stopwatch();
            sw.Start();

            using (var ctx = new MyDbContext())
            {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
                ctx.ARTICLE.AddRange(articles);
                ctx.SaveChanges();
            }

            sw.Stop();
            Console.WriteLine($"Temps insert :{sw.Elapsed}");


            sw.Restart();
            using (var ctx = new MyDbContext())
            {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();
                ctx.BulkInsert<ARTICLE>(articles2, options => options.AutoMapOutputDirection = false);
            }
            sw.Stop();
            Console.WriteLine($"Temps insert :{sw.Elapsed}");

            Console.ReadLine();
        }

       
    }
}

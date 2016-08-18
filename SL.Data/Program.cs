using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            testDb();
        }

        public static void testDb()
        {
            // Console.WriteLine(123);
            // using (var db = new DBContext())
            // {
            // 
            //     var role = new RoleDTO { Name = name };
            //     db.Roles.Add(role);
            //     db.SaveChanges();
            // 
            //     // Display all Blogs from the database 
            //     var query = from b in db.Roles
            //                 orderby b.Name
            //                 select b;
            // 
            //     Console.WriteLine("All blogs in the database:");
            //     foreach (var item in query)
            //     {
            //         Console.WriteLine(item.Name);
            //     }
            // 
            //     Console.WriteLine("Press any key to exit...");
            //     Console.ReadKey();
            // }
        }
    }
}

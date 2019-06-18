using Orm_Basefirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Basefirst.test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Orm_BDDEntities())
            {
                Client client = new Client()
                {
                    Nom = "Malard",
                    Prenom = "Davy",
                    DateNaiss = "04-09-1999",

                };
                db.Clients.Add(client);
                db.SaveChanges();
                Console.WriteLine("Ca a fonctionné !");
                
                Console.ReadKey();
            }
        }
    }
}

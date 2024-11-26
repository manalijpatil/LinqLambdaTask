using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambdaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(1,"Mouse",799,"Dell"),
                new Product(2,"Mouse",699,"Lenovo"),
                new Product(3,"Laptop",34799,"Dell"),
                new Product(4,"Laptop",45799,"Sony"),
                new Product(5,"Keyboard",599,"Dell"),
                new Product(6,"Laptop",75000,"Lenovo"),
                new Product(7,"Keyboard",990,"Microsoft"),
                new Product(8,"Laptop",75000,"Lenovo"),
                new Product(9,"Speaker",5700,"Sony"),
                new Product(10,"USB Mouse",1500,"Microsoft")

            };


            //* Using LINQ query
            Console.WriteLine("-------------------------Using LINQ query-----------------------");
           
            Console.WriteLine("----------1>Display all products using LINQ query");
            var result = from p in products
                         select p;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            //Q.2
            Console.WriteLine("----------2>Display products whose price is greater than 1500");
            var res = from p in products
                      where p.Price>1500
                      select p;
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }



            //Q.3
            Console.WriteLine("----------3>Display products whose price is in between 10000 to 40000");

            var res3 =from p in products
                      where p.Price<=40000 && p.Price>=10000
                      select p;

            foreach (var item in res3)
            {
                Console.WriteLine(item);
            }
            //Q.4
            Console.WriteLine("----------4>Display products of Dell company");

            var res4 = from p in products
                       where p.CompanyName=="Dell"
                       select p;
            foreach (var item in res4)
            {
                Console.WriteLine(item);
            }
            //Q.5
            Console.WriteLine("----------5>Display all company laptops");
            var res5 = from p in products
                       where p.Name == "Laptop"
                       select p;
            foreach (var item in res5)
            {
                Console.WriteLine(item);
            }
            //Q.6
            Console.WriteLine("----------6>Display products whose company name start with ‘M’");
            var res6 =from p in products
                      where p.Name.StartsWith("M")
                      select p;
            foreach (var item in res6)
            {
                Console.WriteLine(item);
            }
            //Q.7
            Console.WriteLine("----------7>Display all company mouse whose price is less than 1000");
            var res7 =from p in products
                      where p.Name=="Mouse" && p.Price<10000
                      select p;
            foreach (var item in res7)
            {
                Console.WriteLine(item);
            }
            //Q.8
            Console.WriteLine("----------8>Display all products descending order by their price");
            var res8 =from p in products
                      orderby p.Price descending
                      select p;
            foreach (var item in res8)
            {
                Console.WriteLine(item);
            }
            //Q.9
            Console.WriteLine("----------9>Display all products accessing order by their company name");
            var res9 = from p in products
                       orderby p.CompanyName
                       select p;
            foreach (var item in res9)
            {
                Console.WriteLine(item);
            }
            //Q.10
            Console.WriteLine("----------10>Display all keyboards accessing order by their price");
            var res10=from p in products
                      where p.Name=="Keyboard"
                      orderby p.Price
                      select p;
            foreach(var item in res10)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------------Using Lambda-----------------------");
            //Q.1>
            Console.WriteLine("----------1>Display all products descending order by their price");
            var result1=products.OrderByDescending(x=> x.Price).ToList();
            foreach(var item in result1)
            {
                Console.WriteLine(item);
            }
            //Q.2>
            Console.WriteLine("---------2>Display product whose Id is 5");
            var result2 = products.Where(x => x.Id == 5).ToList();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
            //Q.3>
            Console.WriteLine("---------3>Display all products whose price less than 5000");
            var result3=products.Where(x => x.Price<5000).ToList();
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }
            //Q.4
            Console.WriteLine("----------4>Display 3 products which have maximum price");
            var result4 = products.OrderBy(x => x.Price).Take(3).ToList();
            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }
            //Q.5
            Console.WriteLine("-----------5>Display 5 products which have minimum price");
            var result5=products.OrderBy(x=>x.Price).Take(5).ToList();
            foreach (var item in result5)
            {
                Console.WriteLine(item);
            }

        }
    }
}

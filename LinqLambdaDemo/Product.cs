using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambdaDemo
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  double Price {  get; set; }
        public string CompanyName {  get; set; }

        public Product(int id, string name, double price ,string cname)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.CompanyName = cname;
        }
        public override string ToString()
        {
            return $"{Id},{Name},{Price},{CompanyName}";
        }
    }
}


using DataAccess.Concrete.EntityFramework;
using System;

namespace ProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var productManager = new EfProductDal();
            
            Console.WriteLine(productManager.GetAll());
        }
    }
}

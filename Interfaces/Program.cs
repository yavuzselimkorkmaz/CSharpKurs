using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Interfaces.OracleServerCustomerDal;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForInterface();
            //Demo();
            

            ICustomerDal[] customerDals = {new SqlServerCustomerDal(),new OracleServerCustomerDal()};

            foreach (var item in customerDals)
            {
                item.add();

            }


            Console.ReadLine();
        }

        private static void Demo()
        {
            IPerson person = new Customer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.add(new SqlServerCustomerDal());
        }

        private static void ForInterface()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Yavuz", LastName = "Korkmaz", Address = "telsiz" });

            Student student1 = new Student
            {
                Id = 2,
                FirstName = "Abdullah",
                LastName = "Yıldırım",
                Department = "Muhendislik"
            };

            manager.Add(student1);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson iperson)
        {
            Console.WriteLine(iperson.FirstName + " eklendi.");
        }
    }
}

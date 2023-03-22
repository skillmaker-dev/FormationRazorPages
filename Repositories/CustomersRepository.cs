using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomersRepository
    {
        public List<Customer> Customers { get; set; } 

        public CustomersRepository() {
            Customers = new List<Customer>()
            {
                new Customer{ Id = 1, Address = "Lazaret Oujda", Email = "john@example.com", FullName = "John Bird" },
                new Customer{ Id = 2, Address = "123 Main St, Anytown USA", Email = "jane@example.com", FullName = "Jane Smith" },
                new Customer{ Id = 3, Address = "44 Oxford St, London, UK", Email = "will@example.com", FullName = "William Brown" },
                new Customer{ Id = 4, Address = "Rua da Praia, Rio de Janeiro, Brazil", Email = "maria@example.com", FullName = "Maria Silva" },
                new Customer{ Id = 5, Address = "Alexanderplatz 1, Berlin, Germany", Email = "hans@example.com", FullName = "Hans Mueller" },
                new Customer{ Id = 6, Address = "4-10-30 Shibuya, Tokyo, Japan", Email = "taro@example.com", FullName = "Taro Yamada" },
                new Customer{ Id = 7, Address = "M.G. Road, Bangalore, India", Email = "priya@example.com", FullName = "Priya Patel" }
            };
        }
    }
}

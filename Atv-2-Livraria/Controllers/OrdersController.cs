using Microsoft.AspNetCore.Mvc;
using Bookstore.Models;

namespace Bookstore.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            // Mock data
            var orders = new List<Order>
            {
                new Order
                {
                    OrderId = 1,
                    EntryDate = DateTime.Now,
                    Status = "Sent",
                    Responsible = "João Silva",
                    Client = new Client
                    {
                        Name = "Maria Oliveira",
                        CPF = "123.456.789-00",
                        Address = "Rua A, 123",
                        Telephone = "(11) 98765-4321",
                        Email = "maria@gmail.com"
                    },
                    Item = new OrderedItem
                    {
                        Description = "Produto X",
                        Value = 100.00m
                    },
                    Supplier = new Supplier
                    {
                        CompanyName = "Empresa Y",
                        Address = "Rua B, 456",
                        DiscountMargin = 10.00m,
                        TaxRegime = "Simples Nacional",
                        CNPJ = "12.345.678/0001-00"
                    }
                }
                // Adicione mais Orders conforme necessário
            };

            return View(orders);
        }

        public IActionResult Details(int id)
        {
            // Mock data
            var order = new Order
            {
                OrderId = id,
                EntryDate = DateTime.Now,
                Status = "Sent",
                Responsible = "João Silva",
                Client = new Client
                {
                    Name = "Maria Oliveira",
                    CPF = "123.456.789-00",
                    Address = "Rua A, 123",
                    Telephone = "(11) 98765-4321",
                    Email = "maria@gmail.com"
                },
                Item = new OrderedItem
                {
                    Description = "Produto X",
                    Value = 100.00m
                },
                Supplier = new Supplier
                {
                    CompanyName = "Empresa Y",
                    Address = "Rua B, 456",
                    DiscountMargin = 10.00m,
                    TaxRegime = "Simples Nacional",
                    CNPJ = "12.345.678/0001-00"
                }
            };

            return View(order);
        }
    }
}
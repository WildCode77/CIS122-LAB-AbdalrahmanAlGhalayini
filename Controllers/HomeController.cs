using Microsoft.AspNetCore.Mvc;
using WebApplicationLab2.Models;

namespace WebApplicationLab2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            FileGateway aGateway = new FileGateway();
            List<Supplier> aListOfSuppliers = aGateway.GetSupplier("C:\\Users\\User\\Documents\\122\\Suppliers.csv");

            ViewBag.ListOfSuppliers = aListOfSuppliers;

            List<Shipper> aListOfShippers = aGateway.GetShipper("C:\\Users\\User\\Documents\\122\\Shippers.csv");

            ViewBag.ListOfShippers = aListOfShippers;

            List<Product> aListOfProducts = aGateway.GetProduct("C:\\Users\\User\\Documents\\122\\Products.csv");

            ViewBag.ListOfProducts = aListOfProducts;

            List<OrderDetails> aListOfOrderDetails = aGateway.GetOrderDetails("C:\\Users\\User\\Documents\\122\\OrderDetails.csv");

            ViewBag.ListOfOrderDetails = aListOfOrderDetails;

            List<Customer> aListOfCustomers = aGateway.GetCustomer("C:\\Users\\User\\Documents\\122\\Customers.csv");

            ViewBag.ListOfCustomers = aListOfCustomers;

            List<Category> aListOfCategories = aGateway.GetCategory("C:\\Users\\User\\Documents\\122\\Categories.csv");

            ViewBag.ListOfCategories = aListOfCategories;

            List<Order> aListOfOrders = aGateway.GetOrder("C:\\Users\\User\\Documents\\122\\Orders.csv");

            ViewBag.ListOfOrders = aListOfOrders;

            List<Employee> aListOfEmployees = aGateway.GetEmployee("C:\\Users\\User\\Documents\\122\\Employees.csv");

            ViewBag.ListOfEmployees = aListOfEmployees;

            return View();
        }
    }
}

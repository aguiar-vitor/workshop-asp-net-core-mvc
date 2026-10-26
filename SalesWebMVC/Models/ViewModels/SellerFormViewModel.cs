using System.Collections.Generic;
using SalesWebMVC.Models;

namespace SalesWebMVC.Models.ViewModels;

public class SellerFormViewModel
{
    public Seller? Seller { get; set; }
    public ICollection<Department> Departments { get; set; } = new List<Department>();
}
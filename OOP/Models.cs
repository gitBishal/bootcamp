using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
   public abstract class BaseCustomer
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string BillAmount { get; set; } = string.Empty;
        public string BillDate { get; set; } = string.Empty;
        public abstract string ValidateModel();
       


    }
    public class Customer : BaseCustomer
    {
        public override string ValidateModel() =>
            string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(PhoneNumber) ||
            string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(BillAmount) ||
            string.IsNullOrEmpty(BillDate)?"Validtion failed":"Validation passed";
       

    }
    public class Lead : BaseCustomer
    {
        public override string ValidateModel() =>
              string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(PhoneNumber) ||
            string.IsNullOrEmpty(Address)?"Validaiton failed":"Validation passed";


    }
    public class Factory
    {
        private List<BaseCustomer> customers = new List<BaseCustomer>();
        public BaseCustomer Create(int CustomerType)
        {
            if (customers.Count == 0) LoadCustomers();
            return customers[CustomerType];
        }
        public void LoadCustomers()
        {
            customers.Add(new Lead());
            customers.Add(new Customer());
        }
    }
}

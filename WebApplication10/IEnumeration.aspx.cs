using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10
{
    public partial class IEnumeration : System.Web.UI.Page
    {
          protected void Page_Load(object sender, EventArgs e)
            {
            }
            protected void Button1_Click(object sender, EventArgs e)
            {
                foreach (var cust in GetAllCustomer())
                {
                    Response.Write("Name: " + cust.Name + "<br> " + "City: " + cust.City + " <br> "
                              + "Mobile " + cust.Mobile + "<br> " + "Amount :" + cust.Amount.ToString("c") + "<br>" + "-----" + "<br>");
                }
            }
            public class Customer
            {
                private String _Name, _City;
                private long _Mobile;
                private double _Amount;

                public String Name
                {
                    get { return _Name; }
                    set { _Name = value; }
                }
                public String City
                {
                    get { return _City; }
                    set { _City = value; }
                }

                public long Mobile
                {
                    get { return _Mobile; }
                    set { _Mobile = value; }
                }
                public double Amount
                {
                    get { return _Amount; }
                    set { _Amount = value; }
                }
            }
            Customer[] customers = new Customer[]
            {

            new Customer {Name="Vithal Wadje",City="Mumbai",Mobile=9999999,Amount=89.45 },
            new Customer { Name = "Sudhir Wadje", City = "Latur", Mobile = 8888888, Amount =426.00 },
            new Customer { Name = "Anil Srivastava", City = "Delhi", Mobile = 7999999999, Amount = 96.20 }
            };

        public IEnumerable<Customer> GetAllCustomer()
        {
            return customers;
        }
    }
    }

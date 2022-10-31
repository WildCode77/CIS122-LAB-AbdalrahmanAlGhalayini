using System;


namespace WebApplicationLab2
{
    public class Shipper
    {
        //local variables
        public int shipperId = 0;
        public string company = "n/a";
        public string phone = "n/a";

        public int ShipperId
        {
            get { return this.shipperId; }
            set 
            { 
                if (value > -1)
                {
                    this.shipperId = value;
                }
                else
                {
                    this.shipperId = 0;
                } 
            }
        }
        // gets and sets
        public string Company
        {
            get { return this.company; }
            set {this.company = value; }
        }

        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value;  }
        }

        public Shipper(): this(-1, "n/a", "n/a")
        {
            // empty constructor
        }
        
        public Shipper(int theShipperId, string theCompany, string aPhone)
        {
            //full constructor
            this.ShipperId = theShipperId;
            this.Company = theCompany;
            this.Phone = aPhone;
        }
        
        // object representer
        public override string ToString()
        {
            string message = "";
            message = message + "ShipperId: " + this.ShipperId + "\n";
            message = message + "Company: " + this.Company + "\n";
            message = message + "PhoneL " + this.Phone + "\n";
            return message;
        }
    }
}
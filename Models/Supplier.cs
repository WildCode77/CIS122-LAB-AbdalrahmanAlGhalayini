

namespace WebApplicationLab2
{
    public class Supplier
    {
        // local variables
        public int supplierId = -1;
        public string companyName = "n/a";
        public string contactName = "n/a";
        public string address = "n/a";
        public string city = "n/a";
        public string region = "n/a";
        public string postalCode = "n/a";
        public string country = "n/a";
        public string phone = "n/a";
        public string fax = "n/a";
        public string homePage = "n/a";
        
        // gets and sets
        public int SupplierId
        {
            get { return this.supplierId;  } 
            set 
            { 
                if (value > -1) 
                { 
                    this.supplierId = value; 
                }
                else 
                {   
                    this.supplierId = 0; 
                }
            } 
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }   
        }
        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }
        public string Homepage
        {
            get { return this.homePage; }
            set { this.homePage = value; }
        }

        public Supplier(): this(-1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", 
        "n/a", "n/a", "n/a", "n/a")
        {
            // empty constructor
        }

        public Supplier(int theSupplierId, string theCompanyName, string theContactName, 
        string theAddress, string aCity,  string aRegion, string aPostalCode, string aCountry,
        string aPhone, string aFax, string aHomepage)
        {
            //full constructor
            this.SupplierId = theSupplierId;
            this.CompanyName = theCompanyName;
            this.ContactName = theContactName;
            this.Address = theAddress;
            this.City = aCity;
            this.Region = aRegion;
            this.PostalCode = aPostalCode;
            this.Country = aCountry;
            this.Phone = aPhone;
            this.Fax = aFax;
            this.Homepage = aHomepage; 
        }
        //object representer
        public override string ToString()
        {
            string message = "";
            message = message + "SupplierId: " + this.SupplierId + "\n";
            message = message + "CompanyName: " + this.CompanyName + "\n";
            message = message + "ContactName: " + this.ContactName + "\n";
            message = message + "Address: " + this.Address + "\n";
            message = message + "City: " + this.City + "\n";
            message = message + "Region: " + this.Region + "\n";
            message = message + "PostalCode: " + this.PostalCode + "\n";
            message = message + "Country: " + this.Country + "\n";
            message = message + "Phone: " + this.Phone + "\n";
            message = message + "Fax: " + this.Fax + "\n";
            message = message + "HomePage: " + this.homePage + "\n";
            return message;
        }
    }
    
}
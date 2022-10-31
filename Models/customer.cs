// Abdalrahman AlGhalayini
// 8/26/2022

using System;


namespace WebApplicationLab2
{
	public class Customer
	{
        // local variables
        public string customerId = "n/a";
        public string companyName = "n/a";
        public string contactName = "n/a";
        public string contactTitle = "n/a";
        public string address = "n/a";
        public string city = "n/a";
        public string region = "n/a";
        public string postalCode = "n/a";
        public string country = "n/a";
        public string phone = "n/a";
        public string fax = "n/a";

		// gets and sets 
		public string CustomerId
		{
			get { return this.customerId; }
			set { this.customerId = value; }
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

		public string ContactTitle 
		{
			get { return this.contactTitle; }
			set { this.contactTitle = value; }
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

		public Customer(): this("n/a", "n/a", "n/a", "n/a", "n/a", 
		"n/a", "n/a","n/a", "n/a", "n/a", "n/a")
		{
			// empty constuctor
		}

		public Customer(string theCustomerId, string theCompanyName, string theContactName, 
		string theContactTitle, string theAddress, string theCity, string theRegion, 
		string thePostalCode, string theCountry, string thePhone, string theFax)
		{
			// full constructor
			this.CustomerId = theCustomerId;
			this.CompanyName = theCompanyName;
			this.ContactName = theContactName;
			this.ContactTitle = theContactTitle;
			this.Address = theAddress;
			this.City = theCity;
			this.Region = theRegion;
			this.PostalCode = thePostalCode;
			this.Country = theCountry;
			this.Phone = thePhone;
			this.Fax = theFax;
		}
		// object representer
		public override string ToString()
		{
			string message = "";
			message = message + "CustomerId: " + this.CustomerId + "\n";
			message = message + "CompanyName: " + this.CompanyName + "\n";
            message = message + "ContactName: " + this.ContactName + "\n";
			message = message + "ContactTitle: " + this.ContactTitle + "\n";
            message = message + "Address: " + this.Address + "\n";
            message = message + "City: " + this.City + "\n";
            message = message + "Region: " + this.Region + "\n";
            message = message + "PostalCode: " + this.PostalCode + "\n";
            message = message + "Country: " + this.Country + "\n";
            message = message + "Phone: " + this.Phone + "\n";
            message = message + "Fax: " + this.Fax + "\n";
			return message;
			
		}
	}
}
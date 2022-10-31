// Abdalrahman AlGhalayini
// 8/26/2022




namespace WebApplicationLab2
{
	public class Employee
	{
		// local variables
		public int employeeId = -1;
        public string lastName = "n/a";
        public string firstName = "n/a";
        public string title = "n/a";
        public string titleOfCourtesy = "n/a";
        public string birthDate = "n/a";
        public string hireDate = "n/a";
        public string address = "n/a";
        public string city = "n/a";
        public string region = "n/a";
        public string postalCode = "n/a";
        public string country = "n/a";
        public string homePhone = "n/a";
        public string extension = "n/a";
        public string notes = "n/a";
        public int reportsTo = -1;

		// gets and sets
		public int EmployeeId
		{
			get { return this.employeeId; }
			set { this.employeeId = value; }
		}

		public string LastName 
		{
			get { return this.lastName; }
			set { this.lastName = value; }
		}

		public string FirstName
		{
			get { return this.firstName; }
			set { this.firstName = value; }
		}

		public string Title 
		{
			get { return this.title; }
			set { this.title = value; }
		}

		public string TitleOfCourtesy 
		{
			get { return this.titleOfCourtesy; }
			set { this.titleOfCourtesy = value; }
		}

		public string BirthDate
		{
			get { return this.birthDate; }
			set { this.birthDate = value; }
		}
		public string HireDate
		{
			get { return this.hireDate; }
			set { this.hireDate = value; }
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
			get {return this.region; }
			set { this.region = value; }
		}

		public string PostalCode 
		{
			get {return this.postalCode; }
			set { this.postalCode = value; }
		}

		public string Country
		{
			get {return this.country; }
			set { this.country = value; }
		}

		public string HomePhone
		{
			get {return this.homePhone; }
			set { this.homePhone = value; }
		}
		public string Extension 
		{
			get {return this.extension; }
			set { this.extension = value; }
		}
		public string Notes 
		{
			get {return this.notes; }
			set { this.notes = value; }
		}
		public int ReportsTo
		{
			get {return this.reportsTo; }
			set 
			{ 
				if( value >= -1 )
				{
					this.reportsTo = value;
				}
				else
				{
					this.reportsTo = 0;
				}
				 
			}
		}

		public Employee(): this(-1, "n/a", "n/a", "n/a", "n/a", 
		"n/a", "n/a","n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", -1)
		{
			// empty constuctor
		}

		public Employee(int theEmployeeId, string theLastName, string theFirstName, 
		string theTitle, string theTitleOfCourtesy, string theBirthDate, 
		string theHireDate, string theAddress, string theCity, string theRegion, 
		string thePostalCode, string theCountry, string theHomePhone, string theExtension, 
		string theNotes, int ReportsToWho)
		{
			// Full Constructor
			this.EmployeeId = theEmployeeId;
			this.LastName = theLastName;
			this.FirstName = theFirstName;
			this.Title = theTitle;
			this.TitleOfCourtesy = theTitleOfCourtesy;
			this.BirthDate = theBirthDate;
			this.HireDate = theHireDate;
			this.Address = theAddress;
			this.City = theCity;
			this.Region = theRegion;
			this.PostalCode = thePostalCode;
			this.Country = theCountry;
			this.HomePhone = theHomePhone;
			this.Extension = theExtension;
			this.Notes = theNotes;
			this.ReportsTo = ReportsToWho;
		}
		// object representer
		public override string ToString()
		{
			string message = "";
			message = message + "EmployeeId: " + this.EmployeeId + "\n";
			message = message + "LastName: " + this.LastName + "\n";
			message = message + "FirstName: " + this.FirstName + "\n";
			message = message + "Title: " + this.Title + "\n";
			message = message + "TitleOfCourtesy: " + this.TitleOfCourtesy + "\n";
			message = message + "BirthDate: " + this.BirthDate + "\n";
            message = message + "HireDate: " + this.HireDate + "\n";
            message = message + "Address: " + this.Address + "\n";
            message = message + "City: " + this.City + "\n";
            message = message + "Region: " + this.Region + "\n";
            message = message + "PostalCode: " + this.PostalCode + "\n";
            message = message + "Country: " + this.Country + "\n";
            message = message + "HomePhone: " + this.HomePhone + "\n";
			message = message + "Extension: " + this.Extension + "\n";
			message = message + "Notes: " + this.Notes + "\n";
			message = message + "ReportsTo: " + this.ReportsTo + "\n";
			return message;
        }

	}
}
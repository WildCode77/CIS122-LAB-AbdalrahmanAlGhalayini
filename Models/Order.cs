// written by Abdalrahman AlGhalayini
// 8/24/2022
// create a project, then create an item. Make sure the item name is capitalized.
using System;



namespace WebApplicationLab2
{
	public class Order
	{
        // local variables
        public int orderId = -1;
        public string customerId = "n/a";
        public int employeeId = -1;
        public string orderDate = "n/a";
        public string requiredDate = "n/a";
        public string shippedDate = "n/a";
        public int shipVia = -1;
        public double freight = 0.0;
        public string shipName = "n/a";
        public string shipAddress = "n/a";
        public string shipCity = "n/a";
        public string shipRegion = "n/a";
        public string shipPostalCode = "n/a";
        public string shipCountry = "n/a";

		//getters and setters
		public int OrderId
		{
			get { return this.orderId; }
			set
			{
				if (value < -1)
				{
					this.orderId = 0;
				}
				else
				{
					this.orderId = value;
				}
			}
		}
		public string CustomerId
		{
			get { return this.customerId; }
			set { this.customerId = value; }
		}
		public int EmployeeId
		{
			get { return this.employeeId; }
			set
			{
				if (value < -1)
				{
					this.employeeId = 0;
				}
				else
				{
					this.employeeId = value;
				}

			}
		}
		public string OrderDate
		{
			get { return this.orderDate; }
			set { this.orderDate = value; }
		}

		public string RequiredDate
		{
			get { return this.requiredDate; }
			set { this.requiredDate = value; }
		}
		public string ShippedDate
		{
			get { return this.shippedDate; }
			set { this.shippedDate = value; }
		}
		public int ShipVia
		{
			get { return this.shipVia; }
			set
			{
				if (value < -1)
				{
					this.shipVia = 0;
				}
				else
				{
					this.shipVia = value;
				}
			}
		}
		public double Freight
		{
			get { return this.freight; }
			set
			{
				if (value < 0.0)
				{
					this.freight = 0.0;
				}
				else
				{
					this.freight = value;
				}
			}
		}
		public string ShipName
		{
			get { return this.shipName; }
			set { this.shipName = value; }
		}
		public string ShipAddress
		{
			get { return this.shipAddress; }
			set { this.shipAddress = value; }
		}
		public string ShipCity
		{
			get { return this.shipCity; }
			set { this.shipCity = value; }
		}
		public string ShipRegion
		{
			get { return this.shipRegion; }
			set { this.shipRegion = value; }

		}
		public string ShipPostalCode
		{
			get { return this.shipPostalCode; }
			set { this.shipPostalCode = value; }
		}
		public string ShipCountry
		{
			get { return this.shipCountry; }
			set { this.shipCountry = value; }
		}

		public Order() : this(-1, "n/a", -1, "n/a", "n/a", "n/a", -1, 9999.99, "n/a", "n/a", "n/a", "n/a",
		"n/a", "n/a")
		{
			//empty constructor
		}

		public Order(int theOrderId, string theCustomerId, int theEmployeeId, string theOrderDate,
		string theRequiredDate, string theShippedDate, int aShipVia, double theFreight,
		string theShipName, string theShipAddress, string theShipCity, string theShipRegion,
		string theShipPostalCode, string theShipCountry)
		{
			//full constructor
			this.OrderId = theOrderId;
			this.CustomerId = theCustomerId;
			this.EmployeeId = theEmployeeId;
			this.OrderDate = theOrderDate;
			this.RequiredDate = theRequiredDate;
			this.ShippedDate = theShippedDate;
			this.ShipVia = aShipVia;
			this.Freight = theFreight;
			this.ShipName = theShipName;
			this.ShipAddress = theShipAddress;
			this.ShipCity = theShipCity;
			this.ShipRegion = theShipRegion;
			this.ShipPostalCode = theShipPostalCode;
			this.ShipCountry = theShipCountry;
		}
		// object representer
		public override string ToString()
		{
			string message = "";
			message = message + "OrderId: " + this.OrderId + "\n";
			message = message + "CustomerId: " + this.CustomerId + "\n";
			message = message + "EmployeeId: " + this.EmployeeId + "\n";
			message = message + "OrderDate: " + this.OrderDate + "\n";
			message = message + "RequiredDate: " + this.RequiredDate + "\n";
			message = message + "ShippedDate: " + this.ShippedDate + "\n";
			message = message + "ShipVia: " + this.ShipVia + "\n";
			message = message + "Freight: " + this.Freight + "\n";
			message = message + "ShipName: " + this.ShipName + "\n";
			message = message + "ShipAddress: " + this.ShipAddress + "\n";
			message = message + "ShipCity: " + this.ShipCity + "\n";
			message = message + "ShipRegion: " + this.ShipRegion + "\n";
			message = message + "ShipPostalCode: " + this.ShipPostalCode + "\n";
			message = message + "ShipCountry: " + this.ShipCountry + "\n";
			return message;

		}
	}
}
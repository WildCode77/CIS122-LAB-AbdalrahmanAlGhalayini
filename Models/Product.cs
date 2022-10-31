// written by Abdalrahman AlGhalayini
// 8/24/2022
// create a project, then create an item. Make sure the item name is capitalized.
using System;


namespace WebApplicationLab2
{
	public class Product
	{
        // local variables
        public int productId = -1;
        public string productName = "n/a";
        public int supplierId = -1;
        public int categoryId = -1;
        public string quantityPerUnit = "n/a";
        public double unitPrice = 0.0;
        public int unitsInStock = -1;
        public int unitsOnOrder = -1;
        public int reorderLevel = -1;
        public bool discontinued = true; 

		//getters and setters
		public int ProductId 
		{
			get { return this.productId; }
			set 
			{
				if ( value < -1)
				{
					this.productId = 0;
				}
				else
				{
					this.productId = value; 
				}
			}

		}
		public string ProductName 
		{
			get { return this.productName; }
			set { this.productName = value; }
		}
		public int SupplierId 
		{
			get { return this.supplierId; }
			set 
			{
				if ( value < -1)
				{
					this.supplierId = 0;
				}
				else
				{
					this.supplierId = value;
				}

			}
		}
		public int CategoryId 
		{
			get { return this.categoryId; }
			set 
			{
				if (value < -1)
				{
					this.categoryId = 0;
				}
				else
				{
					this.categoryId = value;
				}
			}
		}
		public string QuantityPerUnit 
		{
			get { return this.quantityPerUnit; }
			set { this.quantityPerUnit = value; }
		}
		public double UnitPrice 
		{
			get { return this.unitPrice; }
			set 
			{
				if (value < 0.0)
				{
					this.unitPrice = 0.0;
				}
				else
				{
					this.unitPrice = value;
				}
			}
		}
		public int UnitsInStock
		{
			get { return this.unitsInStock; }
			set
			{
				if (value < -1)
				{
					this.unitsInStock = 0;
				}
				else
				{
					this.unitsInStock = value;
				}
			}
		}
		public int UnitsOnOrder
		{
			get { return this.unitsOnOrder; }
			set 
			{
				if (value < -1)
				{
					this.unitsOnOrder = 0;
				}
				else
				{
					this.unitsOnOrder = value;
				}
			}
		}
		public int ReorderLevel 
		{
			get { return this.reorderLevel; }
			set 
			{
				if ( value < -1 )
				{
					this.reorderLevel = 0;
				}
				else
				{
					this.reorderLevel = value;
				}
			}
		}
		public bool Discontinued 
		{
			get { return this.discontinued; }
			set { this.discontinued = value; }
		}

		public Product():this(-1, "n/a", -1, -1, "n/a", 9999.99, -1, -1, -1, true)
		{
			//empty constructor 
		}
		public Product(int theProductId, string theProductName, int theSupplierId, int theCategoryId,
		string theQuantityPerUnit, double theUnitPrice, int theUnitsInStock, 
		int theUnitsOnOrder, int theReorderLevel, bool ifDiscontinued)
		{
			//full constructor
			this.ProductId = theProductId;
			this.ProductName = theProductName;
			this.SupplierId = theSupplierId;
			this.CategoryId = theCategoryId;
			this.QuantityPerUnit = theQuantityPerUnit;
			this.UnitPrice = theUnitPrice;
			this.UnitsInStock = theUnitsInStock;
			this.UnitsOnOrder = theUnitsOnOrder;
			this.ReorderLevel = theReorderLevel;
			this.Discontinued = ifDiscontinued;
		}
		//object representer 
		public override string ToString()
		{
			string message = "";
            message = message + "ProductId: " + this.ProductId + "\n";
            message = message + "ProductName: " + this.ProductName + "\n";
            message = message + "SupplierId: " + this.SupplierId + "\n";
            message = message + "CategoryId: " + this.CategoryId + "\n";
            message = message + "QuantityPerUnit: " + this.QuantityPerUnit + "\n";
            message = message + "UnitPrice: " + this.UnitPrice + "\n";
            message = message + "UnitsInStock: " + this.UnitsInStock + "\n";
            message = message + "UnitsOnOrder: " + this.UnitsOnOrder + "\n";
            message = message + "ReorderLevel: " + this.ReorderLevel + "\n";
            message = message + "Discontinued: " + this.Discontinued + "\n";
			return message;
        }
	}
}
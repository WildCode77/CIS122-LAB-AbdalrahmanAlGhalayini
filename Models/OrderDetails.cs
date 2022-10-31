// written by Abdalrahman AlGhalayini
// 8/24/2022
// create a project, then create an item. Make sure the item name is capitalized.


namespace WebApplicationLab2
{
	public class OrderDetails
	{
        //local variables
        public int orderId = -1;
        public int productId = -1;
        public double unitPrice = 0.0;
        public int quantity = -1;
        public double discount = 0.0;
	
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
		public int ProductId 
		{
			get { return this.productId; }
			set 
			{
				if (value < -1)
				{
					this.productId = 0;
				}
				else
				{
					this.productId = value;
				}
			}

		}
		public double UnitPrice 
		{
			get { return this.unitPrice; }
			set 
			{ 
				if (value < 0.0)
				{
					this.unitPrice = 0;
				}
				else
				{
					this.unitPrice = value; 
				}
			}		
		}

		public int Quantity 
		{
			get { return this.quantity; }
			set 
			{
				if (value < -1)
				{
					this.quantity = 0;
				}
				else
				{
					this.quantity = value; 
				}
			}
		}
	
		public double Discount 
		{
			get { return this.discount; }
			set
			{
				if (value > -1)
				{
                    this.discount = value;
				}
				else
				{
                    this.discount = 0;
                }
			}
		}
		public OrderDetails(): this(-1,-1,9999.99,-1,9999.99)
		{
			//empty constructor
		}
		public OrderDetails(int theOrderId,int theProductId, double theUnitPrice, 
		int theQuantity, double theDiscount)
		{
			//full constructor
			this.OrderId = theOrderId;
			this.ProductId = theProductId;
			this.UnitPrice = theUnitPrice;
			this.Quantity = theQuantity;
			this.Discount = theDiscount;
		}
		// object representer
		public override string ToString()
		{
			string message = "";
			message = message + "OrderId: " + this.OrderId + "\n";
			message = message + "ProductId: " + this.ProductId + "\n";
			message = message + "UnitPrice: " + this.UnitPrice + "\n";
			message = message + "Quantity: " + this.Quantity + "\n";
			message = message + "Discount: " + this.Discount + "\n";
			return message;

        }
	}
}
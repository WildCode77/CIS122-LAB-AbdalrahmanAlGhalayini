// Abdalrahman AlGhalayini
// 8/26/2022

using System;


namespace WebApplicationLab2
{
	public class Category 
	{
        // class variables (instances)
        public string categoryName = "n/a";
        public int categoryId = -1;
        public string description = "n/a";

		// Encapsulation
		// getters and setters or accessors and mutators 
		public string CategoryName 
		{
			get { return this.categoryName; }
			set { this.categoryName = value; }
		}

		public int CategoryId
		{
			get { return this.categoryId; }
			set 
			{ 
				if (value >= - 1)
				{
					this.categoryId = value;
				}
				else
				{
					this.categoryId = 0;
				}
				 
			}
		}

		public string Description
		{
			get { return this.description; }
			set { this.description = value; }
		}

		public Category(): this("n/a", -1, "n/a")
        {
            // empty constructor
        }
        
        public Category(string theCategoryName, int theCategoryId, string theDescription)
        {
            //full constructor
            this.CategoryName = theCategoryName;
            this.CategoryId = theCategoryId;
            this.Description = theDescription;
        }
        
		//object representer
		public override string ToString()
		{
			string message = "";
			message = message + "CategoryName: " + this.CategoryName + "\n";
			message = message + "CategoryId: " + this.CategoryId + "\n";
			message = message + "Description: " + this.description + "\n";
			return message;
        }
	}
	
}
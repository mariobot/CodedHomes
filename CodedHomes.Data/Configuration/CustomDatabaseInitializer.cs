using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using CodedHomes.Models;

namespace CodedHomes.Data.Configuration
{
    public class CustomDatabaseInitializer : CreateDatabaseIfNotExists<DataContext>
    {
        protected override void Seed(DataContext context)
        {

	  string description = "this is the description, use thes field to input the extra information about the property, care about free of use this space to put extra information. ";

	  int count = 10;

	  while ((count--)!=0)
	  {
	      Home home = new Home();

	      home.StreetAdress = string.Format("15{0} Street St", count);
	      home.City = "Manizales";
	      home.ZipCode = Convert.ToInt16(string.Format("1700{0}", count));
	      home.Bedrooms = ((count % 2) == 1) ? 4 : 3;
	      home.Bathrooms = (home.Bedrooms - 1);
	      home.SquareFeet = 100 * count;
	      home.Price = 2000 * count;
	      home.Description = description;
	      home.ImageName = string.Format("home-{0}.jpg", count);
	      
	      context.Homes.Add(home);
	  }

	  base.Seed(context);
        }
    }
}

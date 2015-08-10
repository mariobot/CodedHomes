using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodedHomes.Data;
using CodedHomes.Models;

namespace CodedHomes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
	  try{
	      Console.WriteLine("Uncomment this section to continue. ");
	      Console.ReadLine();

	      //Console.WriteLine("Initializing the database. . . ");
	      //DataContext context = new DataContext();
	      //Console.WriteLine("Done first installation");
	      //Console.ReadLine();

	      // Use this for test the application and the correct use of DataAcces Loyic
	      //ApplicationUnit appUnit = new ApplicationUnit();
	      //appUnit.Homes.Add(House1());
	      //appUnit.SaveChanges();

	      // Use this for test the application and the correct use of DataAcces Loyic
	      //ApplicationUnit appUnit = new ApplicationUnit();
	      //appUnit.Homes.Add(House2());
	      //appUnit.SaveChanges();
	  }
	  catch (Exception ex){
	      Console.WriteLine(ex.Message);
	      Console.ReadLine();
	  }
        }

        private static Home House1() {
	  Home h1 = new Home
	  {
	      StreetAdress = "FR 45 Str 23",
	      City = "Manizales",
	      ZipCode = 12345,
	      Bedrooms = 3,
	      Bathrooms = 2,
	      SquareFeet = 1000,
	      Price = 1000,
	      Description = "My First House",
	      ImageName = "img1.jpg",

	  };
	  return h1;
        }

        private static Home House2()
        {
	  Home h1 = new Home
	  {
	      StreetAdress = "Str 23 44 12",
	      City = "Manizales",
	      ZipCode = 1212,
	      Bedrooms = 5,
	      Bathrooms = 2,
	      SquareFeet = 1500,
	      Price = 1500,
	      Description = "My Second House",
	      ImageName = "img2.jpg",
	  };
	  return h1;
        }
    }
}

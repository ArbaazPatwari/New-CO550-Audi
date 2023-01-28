using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CW2B_RP_Audi_Team_4.Models;

public static class SeedData
{
    public static void Initialize(AudiContext context)
    {
		AddCars(context);
		AddCustomers(context);
    }

    public static void AddCars(AudiContext context) 
    {
		// Look for any cars.
		if (context.Cars.Any())
		{
			return;   // DB has been seeded
		}

		context.Cars.AddRange(
			new Car
			{
				ModelName = "Audi RS3",
				Brand = "Audi",
				Price = 53620m,
				Description = "The Audi RS3",
				EngineSize = "2.5L V5",
				ZeroToSixty = 4.1m,
				Power = 400,
				Torque = 500,
				FuelType = "Petrol"
			},

			new Car
			{
				ModelName = "Audi RS4",
				Brand = "Audi",
				Price = 67465m,
				Description = "The Audi RS4",
				EngineSize = "2.9L V6",
				ZeroToSixty = 4.1m,
				Power = 450,
				Torque = 600,
				FuelType = "Petrol"
			},

			new Car
			{
				ModelName = "Audi RS5",
				Brand = "Audi",
				Price = 71715m,
				Description = "The Audi RS5",
				EngineSize = "2.9L V6",
				ZeroToSixty = 3.6m,
				Power = 450,
				Torque = 600,
				FuelType = "Petrol"
			},

			new Car
			{
				ModelName = "Audi RS6",
				Brand = "Audi",
				Price = 109570m,
				Description = "The Audi RS6",
				EngineSize = "4.0L V8",
				ZeroToSixty = 3.1m,
				Power = 600,
				Torque = 800,
				FuelType = "Petrol"
			},

			new Car
			{
				ModelName = "Audi RS7",
				Brand = "Audi",
				Price = 116305m,
				Description = "The Audi RS7",
				EngineSize = "4.0L V8",
				ZeroToSixty = 3.0m,
				Power = 600,
				Torque = 800,
				FuelType = "Petrol"
			},

			new Car
			{
				ModelName = "Audi R8",
				Brand = "Audi",
				Price = 132440m,
				Description = "The Audi R8",
				EngineSize = "5.2L V10",
				ZeroToSixty = 2.6m,
				Power = 620,
				Torque = 580,
				FuelType = "Petrol"
			}
		);
		
		context.SaveChanges();
	}
    private static void AddCustomers(AudiContext context)
    {
        // Look for any cars.
        if (context.Customers.Any())
        {
            return;   // DB has been seeded
        }

        context.Customers.AddRange(
            
        );

        context.SaveChanges();
    }
}
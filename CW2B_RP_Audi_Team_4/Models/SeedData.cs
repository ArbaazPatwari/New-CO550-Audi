using Microsoft.EntityFrameworkCore;
using CW2B_RP_Audi_Team_4.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static System.Net.WebRequestMethods;

namespace CW2B_RP_Audi_Team_4.Models;

public static class SeedData
{
    public static void Initialize(AudiContext context)
    {
		AddCars(context);
		AddCustomers(context);
        AddOrders(context);
        AddOrderItems(context);
        AddCarImages(context);
        AddWishlists(context);
    }

    public static void AddCars(AudiContext context) 
    {
		// Look for any cars.
		if (context.Cars.Any())
		{
			return;   // DB has been seeded
		}
        // add any cars here
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
			},

            new Car
            {
                ModelName = "Audi e-tron GT",
                Brand = "Audi",
                Price = 83285m,
                Description = "The Audi e-tron GT",
                EngineSize = "2 AC Asynchronous Motors",
                ZeroToSixty = 3.1m,
                Power = 637,
                Torque = 630,
                FuelType = "electric"
            },

            new Car
            {
                ModelName = "Audi A1 Sportback",
                Brand = "Audi",
                Price = 19760m,
                Description = "The Audi A1 Sportback",
                EngineSize = "1.0 3 Cylinder",
                ZeroToSixty = 7.8m,
                Power = 147,
                Torque = 250,
                FuelType = "Petrol"
            },

            new Car
            {
                ModelName = "Audi TT RS",
                Brand = "Audi",
                Price = 58165m,
                Description = "The Audi TT RS",
                EngineSize = "2.5L 5 Cylinder",
                ZeroToSixty = 3.6m,
                Power = 400,
                Torque = 480,
                FuelType = "Petrol"
            },

            new Car
            {
                ModelName = "Audi Avant 6",
                Brand = "Audi",
                Price = 45415m,
                Description = "The Audi Avant 6",
                EngineSize = "2.0L 4 Cylinder",
                ZeroToSixty = 5.6m,
                Power = 205,
                Torque = 320,
                FuelType = "Petrol"
            }
        );
		
		context.SaveChanges();
	}
    private static void AddCustomers(AudiContext context)
    {
        // Look for any customers.
        if (context.Customers.Any())
        {
            return;   // DB has been seeded
        }

        context.Customers.AddRange(
            // Todo Add customers here
			new Customer 
			{ 
				CustomerName = "Loki Perth",
				CustomerEmail = "lokiperth@gmail.com",
				CustomerPhone = "12345678912",
				CustomerCity = "Maio City",
				CustomerRegion = "4th Ward",
				CustomerAddress = "Seventy Salter Way",
                OrderID = "867190XFH"
            },
			new Customer 
			{
                CustomerName = "Joseph Aldemo",
                CustomerEmail = "josephaldemo@gmail.com",
                CustomerPhone = "83657416639",
                CustomerCity = "Cairo",
                CustomerRegion = "Maadi",
                CustomerAddress = "101 Palm Bunker",
                OrderID = "324791AYN"
            },
            new Customer
            {
                CustomerName = "Chell Hoken",
                CustomerEmail = "chellhoken@gmail.com",
                CustomerPhone = "83746592742",
                CustomerCity = "Lab",
                CustomerRegion = "Upper Floor",
                CustomerAddress = "40 Ninth Sector",
                OrderID = "219043BBF"
            },
            new Customer
            {
                CustomerName = "Daniel Hopkin",
                CustomerEmail = "danielhopkin@gmail.com",
                CustomerPhone = "11236475930",
                CustomerCity = "Newcastle upon Tyne",
                CustomerRegion = "Gateshead",
                CustomerAddress = "91 Roller Street",
                OrderID = "835427POP"
            },
            new Customer
            {
                CustomerName = "Rachel Vera",
                CustomerEmail = "rachelvera@gmail.com",
                CustomerPhone = "77254631903",
                CustomerCity = "Oslo",
                CustomerRegion = "Grorud",
                CustomerAddress = "229 Starlight Lane",
                OrderID = "382423NNQ"
            },
            new Customer
            {
                CustomerName = "Ingrid Tasselworth",
                CustomerEmail = "ingridtasselworth@gmail.com",
                CustomerPhone = "02136590273",
                CustomerCity = "Paris",
                CustomerRegion = "Vaugirard",
                CustomerAddress = "77 Amber Circus",
                OrderID = "832040AJU"
            },
            new Customer
            {
                CustomerName = "Zain Merton",
                CustomerEmail = "zainmerton@gmail.com",
                CustomerPhone = "46385023712",
                CustomerCity = "Los Angeles",
                CustomerRegion = "El Sereno",
                CustomerAddress = "50 Carrera Lane",
                OrderID = "021317YXV"
            },
            new Customer
            {
                CustomerName = "Ursula Van Kampten",
                CustomerEmail = "ursulavancampten@gmail.com",
                CustomerPhone = "46385023712",
                CustomerCity = "Frankfurt",
                CustomerRegion = "Eckenheim",
                CustomerAddress = "67 Neon Place",
                OrderID = "112743HFG"
            },
            new Customer
            {
                CustomerName = "Lord Rottenhelm",
                CustomerEmail = "lordrottenhelm@gmail.com",
                CustomerPhone = "73649284230",
                CustomerCity = "Auckland",
                CustomerRegion = "Waikowhai",
                CustomerAddress = "67 Neon Place",
                OrderID = "689236BWO"
            },
            new Customer
            {
                CustomerName = "Feiri Gigiya",
                CustomerEmail = "feirigigiya@gmail.com",
                CustomerPhone = "56389130902",
                CustomerCity = "Osaka",
                CustomerRegion = "Tennoji Area",
                CustomerAddress = "1 Dragonfly park",
                OrderID = "847921ZZA"
            }
        );

        context.SaveChanges();
    }

    private static void AddOrders(AudiContext context)
    {
        // Look for any orders.
        if (context.Orders.Any())
        {
            return;   // DB has been seeded
        }

        context.Orders.AddRange(
            // Todo Add orders here
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-01"),
                TableNumber = 445,
                CardNumber = "7384926371890978",
                Confirmation = "Carrier SeaShip transporting vehicle",
                DeliveryDate = "13 January",
                DeliveryTracking = "Atlantic Ocean, ETA 12 days"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-02"),
                TableNumber = 283,
                CardNumber = "1234783264905162",
                Confirmation = "Order is in progress",
                DeliveryDate = "End of March",
                DeliveryTracking = "Not dispatched"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-03"),
                TableNumber = 694,
                CardNumber = "3840173483471392",
                Confirmation = "Order is in progress",
                DeliveryDate = "End of February",
                DeliveryTracking = "Not dispatched"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-04"),
                TableNumber = 112,
                CardNumber = "8374659251212068",
                Confirmation = "Order is in progress",
                DeliveryDate = "End of February",
                DeliveryTracking = "Not dispatched"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-05"),
                TableNumber = 112,
                CardNumber = "2840375342358367",
                Confirmation = "Order is in progress",
                DeliveryDate = "End of March",
                DeliveryTracking = "Not dispatched"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-06"),
                TableNumber = 993,
                CardNumber = "8374659251212068",
                Confirmation = "Carrier SuperShip hauler has vehicle",
                DeliveryDate = "13 January",
                DeliveryTracking = "Pacific Ocean, ETA 5 days"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-07"),
                TableNumber = 555,
                CardNumber = "7395673229384459",
                Confirmation = "Order is in progress",
                DeliveryDate = "End of March",
                DeliveryTracking = "Not dispatched"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-08"),
                TableNumber = 239,
                CardNumber = "7492010283747622",
                Confirmation = "Order is in progress",
                DeliveryDate = "22 January",
                DeliveryTracking = "East Asia, ETA in 14 days"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-09"),
                TableNumber = 814,
                CardNumber = "6342679200127341",
                Confirmation = "Order is in progress",
                DeliveryDate = "February",
                DeliveryTracking = "Not dispatched"
            },
            new Order
            {
                OrderDate = DateTime.Parse("2023-01-10"),
                TableNumber = 543,
                CardNumber = "8940321712739406",
                Confirmation = "Order is in progress",
                DeliveryDate = "March",
                DeliveryTracking = "Not dispatched"
            }
        );

        context.SaveChanges();
    }

    public static void AddOrderItems(AudiContext context)
    {
        // Look for any cars.
        if (context.OrderItems.Any())
        {
            return;   // DB has been seeded
        }
        // add any cars here
        context.OrderItems.AddRange(
            new OrderItem
            {
                SalePrice = 53620m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 67465m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 71715m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 109570m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 116305m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 132440m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 83285m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 19760m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 58165m,
                quantity = 1,
            },
            new OrderItem
            {
                SalePrice = 45415m,
                quantity = 1,
            }

        );

        context.SaveChanges();
    }

    public static void AddCarImages(AudiContext context)
    {
        // Look for any cars.
        if (context.CarImages.Any())
        {
            return;   // DB has been seeded
        }
        // add any cars here
        context.CarImages.AddRange(
        new CarImage
        {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-reviews%2Faudi%2Frs3&psig=AOvVaw1GxxAk3QW8BquDu6tfqarc&ust=1675148808997000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCJjD5ODd7vwCFQAAAAAdAAAAABAD",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-reviews%2Frs4-avant%2Frs-4-avant-2019%2Ffirst-drive&psig=AOvVaw3qCpNNYwqqAhUqfg6BJGcy&ust=1675148883626000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCOj564Pe7vwCFQAAAAAdAAAAABAD",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-news%2Fmodified%2Fabt-will-sell-503bhp-audi-rs5-sportback-us&psig=AOvVaw1r8ht61VbQvt0FacfvO7VE&ust=1675148900080000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCKiy1ove7vwCFQAAAAAdAAAAABAo",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-news%2Fmodified%2Faudi-rs6-almost-1000bhp&psig=AOvVaw3cT13cta0Qbq3ZF3x9CzGi&ust=1675148935001000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCLi-uZze7vwCFQAAAAAdAAAAABAD",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-reviews%2Faudi%2Frs7&psig=AOvVaw0QgutYIj0_EP2Usojk4rxo&ust=1675148964204000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCKDdsare7vwCFQAAAAAdAAAAABAD",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-reviews%2Faudi%2Fr8&psig=AOvVaw1NExtjSWQqyIJewqt9YxA_&ust=1675148978909000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCMjnsLHe7vwCFQAAAAAdAAAAABAD",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-reviews%2Faudi%2Fe-tron-gt&psig=AOvVaw1Ggw9HncPqLeW6HS_OX-R6&ust=1675148992105000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCIiE1Lfe7vwCFQAAAAAdAAAAABAD",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-news%2Ffirst-drive-audi-a1-sportback-14-tfsi&psig=AOvVaw3B1-8mqNb4p3n94pprakpi&ust=1675149007644000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCODg2b_e7vwCFQAAAAAdAAAAABAh",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-news%2Fgeneva-motor-show%2Fwatch-out-supra-theres-new-audi-tt-rs&psig=AOvVaw0artqFQt_9P_U5nSZYNF1I&ust=1675149033495000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCMi2nMve7vwCFQAAAAAdAAAAABAI",
                Has3DModel = false
            },
            new CarImage
            {
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.topgear.com%2Fcar-reviews%2Faudi%2Fa6-avant&psig=AOvVaw26GF5ETRj_dmX5MpxHVUDg&ust=1675149055148000&source=images&cd=vfe&ved=0CA8QjRxqFwoTCOj6xdXe7vwCFQAAAAAdAAAAABAD",
                Has3DModel = false
            }


        );

        context.SaveChanges();
    }

    public static void AddWishlists(AudiContext context)
    {
        // Look for any cars.
        if (context.Wishlists.Any())
        {
            return;   // DB has been seeded
        }
        // add any cars here
        context.Wishlists.AddRange(
            new Wishlist 
            {
                ModelName = "Audi RS3",
                Description = "The Audi RS3",
                CustomerName = "Alfred Holmes"
            },
            new Wishlist
            {
                ModelName = "Audi RS4",
                Description = "The Audi RS4",
                CustomerName = "Joseph Aldemo"
            },
            new Wishlist
            {
                ModelName = "Audi RS5",
                Description = "The Audi RS5",
                CustomerName = "Chell Hoken"
            },
            new Wishlist
            {
                ModelName = "Audi RS6",
                Description = "The Audi RS6",
                CustomerName = "Daniel Hopkin"
            },
            new Wishlist
            {
                ModelName = "Audi RS7",
                Description = "The Audi RS7",
                CustomerName = "Rachel Vera"
            },
            new Wishlist
            {
                ModelName = "Audi R8",
                Description = "The Audi R8",
                CustomerName = "Ingrid Tasselworth"
            },
            new Wishlist
            {
                ModelName = "Audi e-tron GT",
                Description = "The Audi e-tron GT",
                CustomerName = "Zain Merton"
            },
            new Wishlist
            {
                ModelName = "Audi A1 Sportback",
                Description = "The Audi A1 Sportback",
                CustomerName = "Ursula Van Kampten"
            },
            new Wishlist
            {
                ModelName = "Audi TT RS",
                Description = "The Audi TT RS",
                CustomerName = "Lord Rottenhelm"
            },
            new Wishlist
            {
                ModelName = "Audi Avant 6",
                Description = "The Audi Avant 6",
                CustomerName = "Feiri Gigiya"
            }

        );

        context.SaveChanges();
    }
}
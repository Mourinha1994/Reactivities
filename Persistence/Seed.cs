using System;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Activities.Any())
            {
                var activities = new List<Activity>
                {
                    new Activity 
                    {
                        Title = "Past Activity 1",
                        Description = "Description of Past Activity 1",
                        Category = "Fun",
                        Date = DateTime.Now.AddMonths(-2),
                        City = "Porto Alegre",
                        Venue = "Usina do Gasômetro"
                    },
                    new Activity
                    {
                        Title = "Past Activity 2",
                        Description = "Description of Past Activity 2",
                        Category = "Shopping",
                        Date = DateTime.Now.AddDays(15),
                        City = "Natal",
                        Venue = "Morro do Careca"
                    },
                    new Activity
                    {
                        Title = "Future Activity 1",
                        Description = "Description of Future Activity 2",
                        Category = "Learning",
                        Date = DateTime.Now.AddMonths(4),
                        City = "São Paulo",
                        Venue = "Av. Paulista"
                    },
                    new Activity
                    {
                        Title = "Future Activity 2",
                        Description = "Description of Future Acitivity 3",
                        Category = "Religion",
                        Date = DateTime.Now.AddMonths(12),
                        City = "Salt Lake City",
                        Venue = "Conference Center"
                    }
                };

                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}
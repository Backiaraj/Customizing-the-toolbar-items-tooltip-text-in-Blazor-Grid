using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public static string GridState { get; set; }
        public void setGridState(string val)
        {
            GridState = val;
        }
        public string GetGridState()
        {
            return GridState;
        }
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
        public List<AppUser> Users = Enumerable.Range(1, 15).Select(x => new AppUser()
        {
            OrderID = 100 + x,
            FirstName = (new string[] { "ALFKI", "ANANTR", "ANTON", "BLONP", "BOLID" })[new Random().Next(5)],
            LastName = (new string[] { "A", "B", "C", "D", "E" })[new Random().Next(5)],
        }).ToList();
        }
    }

using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;

namespace ProductionLine.Models
{
    public class Material
    {
        private static int _statId;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Material()
        {
            Id = _statId++;
            Name = Faker.Commerce.ProductMaterial();
            Type = Faker.Commerce.ProductMaterial();
        }
    }
    [Synchronization]
    public static class Logger
    {
        public static  List<LoggerData> LoggerData=new List<LoggerData>();

        public static void Log(string message,string clas,string thread)
        {
            var ldata = new LoggerData
            {
                Date = DateTime.Now, ThreadClass = clas, ThreadName = thread, Message = message
            };
            LoggerData.Add(ldata);
        }
    }

    public class LoggerData
    {
        public string ThreadName { get; set; }
        public string ThreadClass { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
       
    }
}
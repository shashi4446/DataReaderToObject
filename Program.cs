using System;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new MyDataBuilder().GetDataReader();
            var list = reader.ToObject<ConsumptionEntityModel>();
            foreach (var item in list)
            {
                Console.WriteLine($"Tenant Id => {item.TenantId}, Consumption => {item.ConsumptionUnits}, Date => {item.Date}");
            }
            Console.ReadLine();
        }
    }
}

public class ConsumptionEntityModel
{
    public Guid TenantId { get; set; }
    public DateTime Date { get; set; }
    public decimal ConsumptionUnits { get; set; }

}



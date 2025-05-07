// File: Services/PurchaseMeter.cs
using System.Text.Json;
using ikejaAPI.Models;

namespace ikejaAPI.Services
{
    public class PurchaseMeter
    {
        private readonly string filePath = "C:\\Users\\Tobi Odetola\\Downloads\\meter.txt";

        public void SavePurchaseToFile(MeterClass meter)
        {
            var json = JsonSerializer.Serialize(meter);
            File.WriteAllText(filePath, json);
        }

        public MeterClass GetPurchase()
        {
            if (!File.Exists(filePath)) return null;
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<MeterClass>(json);
        }
    }
}
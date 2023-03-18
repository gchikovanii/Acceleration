using Newtonsoft.Json;
using System.Diagnostics.Metrics;
using System.IO;
using Task_8;

#region Version1 void Type
//GenerateCountryDataFiles();
//void GenerateCountryDataFiles()
//{
//    foreach (var item in country)
//    {
//        var countryName = item.name.common;
//        using (StreamWriter sr = new StreamWriter(path + countryName + ".txt"))
//        {
//            var region = item.region;
//            var subregion = item.subregion;
//            var area = item.area;
//            var population = item.population;
//            var latlng = item.latlng;
//            float firstNum = latlng[0];
//            float secondNum = latlng[1];
//            sr.WriteLine($"Country: {countryName} Region: {region}" +
//            $" subregion: {subregion} " +
//            $"area: {area}" +
//            $" population: {population} latlng: [{firstNum} , {secondNum}]");
//        }
//    }
//}
#endregion

//Version 2
class Program
{
    HttpClient client = new HttpClient();
    string path = @"D:\Acceleration\Task_8\Task_8\Files\";
    static async Task Main(string[] args)
    {
        Program program = new Program();
        await program.GenerateCountryDataFiles();
    }

    public async Task GenerateCountryDataFiles()
    {
        string response = await client.GetStringAsync("https://restcountries.com/v3.1/all");
        List<Country> country = JsonConvert.DeserializeObject<List<Country>>(response);
        foreach (var item in country)
        {
            var countryName = item.name.common;
            using(StreamWriter sr = new StreamWriter(path + countryName + ".txt"))
            {
                var region = item.region;
                var subregion = item.subregion;
                var area = item.area;
                var population = item.population;
                var latlng = item.latlng;
                float firstNum = latlng[0];
                float secondNum = latlng[1];
                sr.WriteLine($"Country: {countryName} Region: {region}" +
                $" subregion: {subregion} " +
                $"area: {area}" +
                $" population: {population} latlng: [{firstNum} , {secondNum}]");
            }
        }
    }
}









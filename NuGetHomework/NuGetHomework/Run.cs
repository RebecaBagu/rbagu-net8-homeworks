using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public static class Run
{
    public static void Main()
    {
        Product product = new Product
        {
            ProductName = "Notebook",
            ProductPrice = 10
        };

        var json = JsonConvert.SerializeObject(product, new JsonSerializerSettings
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new KebabCaseNamingStrategy()
            }
        });

        Console.WriteLine(json);

    }
}


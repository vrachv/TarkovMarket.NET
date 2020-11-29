# TarkovMarket.NET
[![NuGet](https://img.shields.io/nuget/vpre/TarkovMarket.Net.svg?maxAge=2592000?style=plastic)](https://www.nuget.org/packages/TarkovMarket.Net)

C# wrapper for Escape from Tarkov API provided by https://tarkov-market.com

## Note
The API is maintained and provided by tarkov-market.com and all credits go to them. This project just wraps the API for easy usage in C#.

## Installation
To add TarkovMarket.NET to your project, run the following command in the NuGet Package Manager Console:
>Install-Package TarkovMarket.NET

## Getting API key
You can get your API key from here: https://www.patreon.com/tarkov_market

## Usage
Basic example, getting the price of the specified Item in German language.
```csharp
var client = new TarkovMarketClient("api-key-here");
var item = await client.GetItemByNameAsync("ledx", Lang.German).ConfigureAwait(false);
Console.WriteLine($"{item[0].Name} Price: {item[0].Price}");
```

Basic example, getting all Items in default language(English)
```csharp
var client = new TarkovMarketClient("api-key-here");
var items = await client.GetAllItemsAsync("ledx").ConfigureAwait(false);
var str = JsonConvert.SerializeObject(items);
File.WriteAllText("items.json", str);
```

Basic example, getting the tax of the specified Item.
```csharp
var client = new TarkovMarketClient("api-key-here");
var item = await client.GetItemByNameAsync("ledx", Lang.German).ConfigureAwait(false);
var tax = Tax.Base(basePrice: 10000, price: 100000); // custom prices
Console.WriteLine($"Tax: {item[0].Tax}\nTax With Int Center: {item[0].TaxWithIntCenter}"); // target item
```

Basic example, getting the items info from Raw BSG API
```csharp
var client = new TarkovMarketClient("api-key-here");
var items = await client.GetBsgRawAsync().ConfigureAwait(false); // English only

foreach (var item in items)
{
    Console.WriteLine(item.Value.Props.Name);
    Console.WriteLine(item.Value.Props.Prefab?.Path); // Recommended to handle NullReferenceException or use Null-conditional operator
}
```
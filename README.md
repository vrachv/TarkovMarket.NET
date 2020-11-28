# TarkovMarket.NET
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
var item = client.GetItemByNameAsync("ledx", Lang.German).Result;
Console.WriteLine($"{item[0].Name} Price: {item[0].Price}");
```

Basic example, getting all Items in default language(English)
```csharp
var client = new TarkovMarketClient("api-key-here");
var items = client.GetAllItemsAsync("ledx").Result;
var str = JsonConvert.SerializeObject(items);
File.WriteAllText("items.json", str);
```

Basic example, getting the tax of the specified Item.
```csharp
var client = new TarkovMarketClient("api-key-here");
var item = client.GetItemByNameAsync("ledx", Lang.German).Result;
var tax = Tax.Base(item[0]);
var taxWithIntCenter = Tax.WithIntCenter(item[0]);
```
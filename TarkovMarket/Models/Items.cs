using System;
using Newtonsoft.Json;

namespace TarkovMarket.Models
{
    public class Item
    {
        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        
        [JsonProperty("price")]
        public int Price { get; set; }
        
        [JsonProperty("basePrice")]
        public int BasePrice { get; set; }
        
        [JsonProperty("avg24hPrice")]
        public int AvgDayPrice { get; set; }
        
        [JsonProperty("avg7daysPrice")]
        public int AvgWeekPrice { get; set; }
        
        [JsonProperty("traderName")]
        public string TraderName { get; set; }
        
        [JsonProperty("traderPrice")]
        public int TraderPrice { get; set; }
        
        [JsonProperty("traderPriceCur")]
        public string TraderCurrencyPrice { get; set; }
        
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }
        
        [JsonProperty("slots")]
        public int Slots { get; set; }
        
        [JsonProperty("diff24h")]
        public double DiffDayPrice { get; set; }
        
        [JsonProperty("diff7days")]
        public double DiffWeekPrice { get; set; }
        
        [JsonProperty("icon")]
        public string IconUrl { get; set; }
        
        [JsonProperty("link")]
        public string TarkovMarketUrl { get; set; }
        
        [JsonProperty("wikiLink")]
        public string GamepediaUrl { get; set; }
        
        [JsonProperty("img")]
        public string ImgUrl { get; set; }
        
        [JsonProperty("imgBig")]
        public string ImgBigUrl { get; set; }
        
        [JsonProperty("bsgId")]
        public string BsgId { get; set; }
        
        [JsonProperty("isFunctional")]
        public bool IsFunctional { get; set; }
        
        [JsonProperty("reference")]
        public string TarkovMarketPatreon { get; set; }

        public int PricePerSlot => Price / Slots;

        public double Tax => TarkovMarket.Tax.Base(BasePrice, Price);

        public double TaxWithIntCenter => TarkovMarket.Tax.WithIntCenter(BasePrice, Price);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore
        };
    }
}
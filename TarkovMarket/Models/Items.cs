using System;
using System.Collections.Generic;
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

    public class Prefab
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("rcid")]
        public string Rcid { get; set; }
    }

    public class UsePrefab
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("rcid")]
        public string Rcid { get; set; }
    }

    public class Props
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ShortName")]
        public string ShortName { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Weight")]
        public double Weight { get; set; }

        [JsonProperty("BackgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("Width")]
        public int Width { get; set; }

        [JsonProperty("Height")]
        public int Height { get; set; }

        [JsonProperty("StackMaxSize")]
        public int StackMaxSize { get; set; }

        [JsonProperty("Rarity")]
        public string Rarity { get; set; }

        [JsonProperty("SpawnChance")]
        public double SpawnChance { get; set; }

        [JsonProperty("CreditsPrice")]
        public int CreditsPrice { get; set; }

        [JsonProperty("ItemSound")]
        public string ItemSound { get; set; }

        [JsonProperty("Prefab")]
        public Prefab Prefab { get; set; }

        [JsonProperty("UsePrefab")]
        public UsePrefab UsePrefab { get; set; }

        [JsonProperty("StackObjectsCount")]
        public int StackObjectsCount { get; set; }

        [JsonProperty("NotShownInSlot")]
        public bool NotShownInSlot { get; set; }

        [JsonProperty("ExaminedByDefault")]
        public bool ExaminedByDefault { get; set; }

        [JsonProperty("ExamineTime")]
        public int ExamineTime { get; set; }

        [JsonProperty("IsUndiscardable")]
        public bool IsUndiscardable { get; set; }

        [JsonProperty("IsUnsaleable")]
        public bool IsUnsaleable { get; set; }

        [JsonProperty("IsUnbuyable")]
        public bool IsUnbuyable { get; set; }

        [JsonProperty("IsUngivable")]
        public bool IsUngivable { get; set; }

        [JsonProperty("IsLockedafterEquip")]
        public bool IsLockedafterEquip { get; set; }

        [JsonProperty("QuestItem")]
        public bool QuestItem { get; set; }

        [JsonProperty("LootExperience")]
        public int LootExperience { get; set; }

        [JsonProperty("ExamineExperience")]
        public int ExamineExperience { get; set; }

        [JsonProperty("HideEntrails")]
        public bool HideEntrails { get; set; }

        [JsonProperty("RepairCost")]
        public int RepairCost { get; set; }

        [JsonProperty("RepairSpeed")]
        public int RepairSpeed { get; set; }

        [JsonProperty("ExtraSizeLeft")]
        public int ExtraSizeLeft { get; set; }

        [JsonProperty("ExtraSizeRight")]
        public int ExtraSizeRight { get; set; }

        [JsonProperty("ExtraSizeUp")]
        public int ExtraSizeUp { get; set; }

        [JsonProperty("ExtraSizeDown")]
        public int ExtraSizeDown { get; set; }

        [JsonProperty("ExtraSizeForceAdd")]
        public bool ExtraSizeForceAdd { get; set; }

        [JsonProperty("MergesWithChildren")]
        public bool MergesWithChildren { get; set; }

        [JsonProperty("CanSellOnRagfair")]
        public bool CanSellOnRagfair { get; set; }

        [JsonProperty("CanRequireOnRagfair")]
        public bool CanRequireOnRagfair { get; set; }

        [JsonProperty("ConflictingItems")]
        public List<object> ConflictingItems { get; set; }

        [JsonProperty("FixedPrice")]
        public bool FixedPrice { get; set; }

        [JsonProperty("Unlootable")]
        public bool Unlootable { get; set; }

        [JsonProperty("UnlootableFromSlot")]
        public string UnlootableFromSlot { get; set; }

        [JsonProperty("UnlootableFromSide")]
        public List<object> UnlootableFromSide { get; set; }

        [JsonProperty("ChangePriceCoef")]
        public int ChangePriceCoef { get; set; }

        [JsonProperty("AllowSpawnOnLocations")]
        public List<object> AllowSpawnOnLocations { get; set; }

        [JsonProperty("SendToClient")]
        public bool SendToClient { get; set; }

        [JsonProperty("AnimationVariantsNumber")]
        public int AnimationVariantsNumber { get; set; }

        [JsonProperty("DiscardingBlock")]
        public bool DiscardingBlock { get; set; }

        [JsonProperty("MaxResource")]
        public int MaxResource { get; set; }

        [JsonProperty("Resource")]
        public int Resource { get; set; }
    }

    public class BsgRaw
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_name")]
        public string Name { get; set; }

        [JsonProperty("_parent")]
        public string Parent { get; set; }

        [JsonProperty("_type")]
        public string Type { get; set; }

        [JsonProperty("_props")]
        public Props Props { get; set; }

        [JsonProperty("_proto")]
        public string Proto { get; set; }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore
        };
    }
}
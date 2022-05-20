using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using TarkovMarket.Exceptions;
using TarkovMarket.Http;
using TarkovMarket.Models;

namespace TarkovMarket;

public class TarkovMarketClient : IDisposable
{
    private readonly Request _httpRequest;

    /// <summary>
    /// Initialises a <see cref="TarkovMarketClient"/>.
    /// </summary>
    /// <param name="apiKey">Your tarkov-market Api key (https://www.patreon.com/tarkov_market)</param>
    public TarkovMarketClient(string apiKey)
    {
        if (string.IsNullOrEmpty(apiKey))
        {
            throw new TarkovMarketException("Api key cannot be empty.");
        }

        _httpRequest = new Request(apiKey);
    }

    /// <summary>
    /// Initialises a <see cref="TarkovMarketClient"/>.
    /// </summary>
    /// <param name="itemName">Item name you search.</param>
    /// <param name="lang">Response language <see cref="Lang"/>.</param>
    public async Task<TarkovItems> GetItemByNameAsync(string itemName, Lang lang = Lang.English)
    {
        if (string.IsNullOrEmpty(itemName))
        {
            throw new TarkovMarketException("Item name cannot be empty.");
        }

        var langString = lang.ToLanguageString();
        var request = $"item?q={itemName}&lang={langString}";

        return await _httpRequest.GetAsync(request).ConfigureAwait(false);
    }

    /// <summary>
    /// Initialises a <see cref="TarkovMarketClient"/>.
    /// </summary>
    /// <param name="uid">Item uid you search.</param>
    /// <param name="lang">Response language <see cref="Lang"/>.</param>
    public async Task<TarkovItems> GetItemByUidAsync(string uid, Lang lang = Lang.English)
    {
        if (string.IsNullOrEmpty(uid))
        {
            throw new TarkovMarketException("Uid cannot be empty.");
        }

        var langValue = lang.ToLanguageString();
        var request = $"item?uid={uid}&lang={langValue}";

        return await _httpRequest.GetAsync(request).ConfigureAwait(false);
    }

    /// <summary>
    /// Initialises a <see cref="TarkovMarketClient">.
    /// </summary>
    /// <param name="lang">Response language <see cref="Lang"/>.</param>
    public async Task<TarkovItems> GetAllItemsAsync(Lang lang = Lang.English)
    {
        var langValue = lang.ToLanguageString();
        var request = $"items/all?lang={langValue}";

        return await _httpRequest.GetAsync(request).ConfigureAwait(false);
    }

    /// <summary>
    /// Initialises a <see cref="TarkovMarketClient">.
    /// </summary>
    public async Task<Dictionary<string, BsgRaw>> GetBsgRawAsync()
    {
        return await _httpRequest.GetBsgRawAsync("bsg/items/all").ConfigureAwait(false);
    }

    public void Dispose()
    {
        _httpRequest?.Dispose();
        GC.SuppressFinalize(this);
    }
}
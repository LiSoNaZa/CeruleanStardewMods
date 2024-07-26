﻿using System;
using System.Collections.Generic;

namespace MarketDay.API
{
    /// <summary>
    /// Interface for Json Assets API
    /// </summary>
    public interface IJsonAssetsApi
    {
        List<string> GetAllObjectsFromContentPack(string cp);
        List<string> GetAllCropsFromContentPack(string cp);
        List<string> GetAllFruitTreesFromContentPack(string cp);
        List<string> GetAllBigCraftablesFromContentPack(string cp);
        List<string> GetAllHatsFromContentPack(string cp);
        List<string> GetAllWeaponsFromContentPack(string cp);
        List<string> GetAllClothingFromContentPack(string cp);

        // int GetCropId(string name);
        // int GetFruitTreeId(string name);

        event EventHandler AddedItemsToShop;
    }
}

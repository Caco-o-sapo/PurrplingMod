﻿using System.Collections.Generic;

namespace NpcAdventure.Loader
{
    public interface IContentLoader
    {
        bool CanLoad(string assetName);
        T Load<T>(string assetName);
        Dictionary<string, string> LoadStrings(string stringsAssetName);
        string LoadString(string path);
        string LoadString(string path, params object[] substitutions);
        void InvalidateCache();
    }
}
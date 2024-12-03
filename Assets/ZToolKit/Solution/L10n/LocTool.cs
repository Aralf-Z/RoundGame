using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using cfg;
using UnityEngine;

namespace ZToolKit
{
    public enum Language
    {
        English,
        Chinese,
    }

    public static class LocTool
    {
        public static Language Language
        {
            get => sLanguage;
            set => Set(value);
        }
        
        public static TbLocUi UiL10n => CfgTool.Tables.TbLocUi;
        public static TbLocGame GameL10n => CfgTool.Tables.TbLocGame;
        
        public static event Action Event_OnChangeLanguage;
        
        private static Language sLanguage;

        static LocTool()
        {
            Language = Language.Chinese;
        }

        private static void Set(Language language)
        {
            sLanguage = language;
            Event_OnChangeLanguage?.Invoke();
        }
        
        public static string GetUIStr(Transform refTransform, string key)
        {
            if(UiL10n.DataMap.TryGetValue(key, out var l10N))
            {
                return sLanguage switch
                {
                    Language.Chinese => l10N.Cn,
                    Language.English => l10N.En,
                    _ => default,
                };
            }
            
            LogTool.ToolError("LocTool",$"Invalid Key:{key}, path:{refTransform.GetPath()}");
            return default;
        }

        public static string GetGameStr(string key)
        {
            if(GameL10n.DataMap.TryGetValue(key, out var loc))
            {
                return sLanguage switch
                {
                    Language.Chinese => loc.Cn,
                    Language.English => loc.En,
                    _ => default,
                };
            }
            
            LogTool.ToolError("LocTool",$"Invalid Key:{key}");
            return default;
        }
    }
}
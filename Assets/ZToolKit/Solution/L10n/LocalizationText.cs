using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ZToolKit
{
    [RequireComponent(typeof(Text))]
    public class LocalizationText : LocalizationBase
    {
        protected override void OnLanguageChange()
        {
            ((Text)target).text = LocTool.GetUIStr((RectTransform)transform, key);
        }
    }
}

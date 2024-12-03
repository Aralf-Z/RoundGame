using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ZToolKit
{
    [RequireComponent(typeof(Image))]
    public class LocalizationImage : LocalizationBase
    {
        protected override void OnLanguageChange()
        {
           ((Image)target).sprite = ResTool.Load<Sprite>(LocTool.GetUIStr((RectTransform)transform, key));
        }
    }
}
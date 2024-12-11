using System.Collections;
using System.Collections.Generic;

namespace ZToolKit
{
    public static partial class Extension
    {
        public static T GetRandom<T>(this List<T> list)
        {
            return list[UnityEngine.Random.Range(0, list.Count)];
        }
    }
}
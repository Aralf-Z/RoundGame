using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZToolKit
{
    public interface IEntities<T, K>
    {
        List<T> Entities { get; set;}
        void Init();
        T Spawn(K data);
        void Clear();
    }
}

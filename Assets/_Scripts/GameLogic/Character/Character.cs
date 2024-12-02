using System;
using System.Collections;
using System.Collections.Generic;
using cfg;
using UnityEngine;

namespace RoundGame
{
    [RequireComponent(typeof(ChaAnimation))]
    public class Character : MonoBehaviour
    {
        public ChaAnimation Animation { get;private set; }
        
        private void Awake()
        {
            Animation = GetComponent<ChaAnimation>();
        }
    }
}

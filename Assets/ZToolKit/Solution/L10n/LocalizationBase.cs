using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ZToolKit
{
    [DisallowMultipleComponent]
    public abstract class LocalizationBase : MonoBehaviour
    {
        public Graphic target;
        
        public string key;

        private void Awake()
        {
            OnLanguageChange();
            LocTool.Event_OnChangeLanguage += OnLanguageChange;
        }

        private void OnEnable()
        {
            OnLanguageChange();
            LocTool.Event_OnChangeLanguage += OnLanguageChange;
        }

        private void OnDisable()
        {
            LocTool.Event_OnChangeLanguage -= OnLanguageChange;
        }

        private void OnDestroy()
        {
            LocTool.Event_OnChangeLanguage -= OnLanguageChange;
        }

        protected abstract void OnLanguageChange();

#if UNITY_EDITOR
        protected virtual void OnValidate()
        {
            target = transform.GetComponent<Graphic>();
        }
#endif
    }
}

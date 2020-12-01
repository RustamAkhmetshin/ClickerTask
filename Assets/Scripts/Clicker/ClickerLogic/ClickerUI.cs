using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Clicker
{
    public class ClickerUI : MonoBehaviour, ISubscriber
    {
        [SerializeField] private Text _clicksCountText;

        private void OnEnable()
        {
            EventManager.Subscribe(this);
        }

        private void OnDisable()
        {
            EventManager.Unsubscribe(this);
        }

        public void RaiseEvent(string text)
        {
            _clicksCountText.text = text;
        }
    }
}
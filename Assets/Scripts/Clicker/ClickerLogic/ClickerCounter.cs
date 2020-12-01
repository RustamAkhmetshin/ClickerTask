using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Clicker
{
    public class ClickerCounter : IClickerCounter
    {

        private int _clickCount;

        public ClickerCounter()
        {
            _clickCount = 0;
        }

        public void IncrementClicks()
        {
            _clickCount++;
            EventManager.RaiseEvent(_clickCount.ToString());
        }
    }
}


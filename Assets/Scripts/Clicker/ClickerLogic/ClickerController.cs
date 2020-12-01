using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Clicker
{
    public class ClickerController : MonoBehaviour
    {
        [SerializeField] private Button _clickButton;

        private IClickerCounter _clickerCounter;

        private void Start()
        {
            InitController(new ClickerCounter());
            _clickButton.onClick.AddListener(OnIncrementButtonClicked);
        }

        public void InitController(IClickerCounter clickerCounter)
        {
            _clickerCounter = clickerCounter;
        }

        public void OnIncrementButtonClicked()
        {
            _clickerCounter.IncrementClicks();
        }
    }
}

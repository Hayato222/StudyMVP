using System;
using UnityEngine;
using UniRx;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Core.Utilities
{
    public class UniRxTest : MonoBehaviour
    {
        private ReactiveProperty<int> valueReactiveProperty = new ReactiveProperty<int>(0);

        public IObservable<int> Observable
        {
            get { return valueReactiveProperty; }
        }
        private void Start()
        {
            SetValue(1);
            SetValue(1);
            SetValue(2);
            SetValue(2);
            SetValue(1);
            
            GetComponent<Button>().OnClickAsObservable().Buffer(2).Subscribe(_ => Debug.Log("偶数"));
        }

        private void SetValue(int value)
        {
            valueReactiveProperty.Value = value;
        }
    }
}


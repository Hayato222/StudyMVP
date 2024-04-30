using System;
using System.Collections;
using System.Threading.Tasks.Sources;
using UnityEngine;
using UniRx;
using UnityEngine.UI;


namespace Core.Utilities
{
    public class UniRxTest : MonoBehaviour
    {
        private ReactiveProperty<int> _valueReactiveProperty = new ReactiveProperty<int>(0);

    }
}


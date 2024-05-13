using System;
using UnityEngine;
using VContainer;

namespace Core.Utilities
{
    public class TestMonoBehaviour : MonoBehaviour
    {
        private HogeClass hogeClass;

        [Inject]
        public void Inject(HogeClass hogeClass)
        {
            this.hogeClass = hogeClass;
        }

        public void Start()
        {
            hogeClass.CalulatorTest(2,3);
        }
    }
}
using UnityEngine;
using UniRx;
namespace Core.Utilities
{
    public class UniRxTest2 : MonoBehaviour
    {
        [SerializeField] private UniRxTest uniRxTest;
        private void Awake()
        {
            uniRxTest.Observable.Subscribe(count => Debug.Log(count));
        }
    }
}
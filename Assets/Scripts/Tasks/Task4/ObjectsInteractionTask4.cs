using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 

    [SerializeField] private Waffle _waffle;
    [SerializeField] private GameObject _waffleRoot;
    [SerializeField] private Toaster _toaster;
    private void Awake()
    {
        _toaster.TimerIsUp += CreatingWaffle;
    }

    private void CreatingWaffle()
    {
        Instantiate(_waffle, _waffleRoot.transform);
        _toaster.TimerIsUp -= CreatingWaffle;
    }
}
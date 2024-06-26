using System;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    [SerializeField] private Shelf[] _shelves;

    private void Awake()
    {
        foreach (var shelf in _shelves)
        {
            shelf.ItemSpawned += shelf.Fall;
        }
    }
}
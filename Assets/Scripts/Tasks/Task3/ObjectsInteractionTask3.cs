using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact
    private Lamp[] _lamps;

    private void Awake()
    {
        _lamps = FindObjectsByType<Lamp>(FindObjectsSortMode.None);
    }

    private void Update()
    {
        foreach (var lamp in _lamps)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                lamp.Interact();
            }
        }
    }
}
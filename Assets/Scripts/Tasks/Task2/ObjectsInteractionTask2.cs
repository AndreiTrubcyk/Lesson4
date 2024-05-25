using System;
using UnityEngine;

public class ObjectsInteractionTask2 : MonoBehaviour
{
    // TODO: В методе Awake создайте на сцене в точке LampRoot одну из наборов ламп (из папки Prefabs/Lamps)    

    [SerializeField] private GameObject _lampPosition;
    [SerializeField] private GameObject _lampPrefab;
    private void Awake()
    {
        //var vector = new Vector3(_lampPosition.transform.position.x, _lampPosition.transform.position.y,
            //_lampPosition.transform.position.z);
        Instantiate(_lampPrefab, _lampPosition.transform);
    }
}
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private ProducedObject prefab;
    [SerializeField] private int poolSize;
    [SerializeField] private float spawnTime;
    private float _spawnTime;
    
    private Queue<ProducedObject> _producedObjects = new Queue<ProducedObject>();

    void Start()
    {
        InitiateObjects();
        _spawnTime = spawnTime;
    }

    void Update()
    {
        _spawnTime -= Time.deltaTime;

        if (_spawnTime <= 0)
        {
            Spawn();
            _spawnTime = spawnTime;
        }
    }

    private void InitiateObjects()
    {
        for (int i = 0; i < poolSize; i++)
        {
            ProducedObject newProducedObject = Instantiate(prefab, transform);
            newProducedObject.gameObject.SetActive(false);
        }
    }

    public void AddQueueNewObject(ProducedObject producedObject)
    {
        _producedObjects.Enqueue(producedObject);
    }

    private void Spawn()
    {
        ProducedObject newProducedObject = _producedObjects.Dequeue();
        newProducedObject.gameObject.SetActive(true);
        newProducedObject.Action(this);
    }
}

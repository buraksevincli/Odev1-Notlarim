using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProducedObject : MonoBehaviour
{
    [SerializeField] private float lifeTime;
    private Spawner _spawner;
    
    public void Action(Spawner spawner)
    {
        _spawner = spawner;
        StartCoroutine(ResetObjectCoroutine());
    }

    IEnumerator ResetObjectCoroutine()
    {
        yield return new WaitForSeconds(lifeTime);
        _spawner.AddQueueNewObject(this);
        gameObject.SetActive(false);
    }
}

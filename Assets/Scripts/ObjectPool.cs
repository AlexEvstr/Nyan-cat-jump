using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;

    private int amountToPool = 15;

    private void Awake()
    {
        SharedInstance = this;
    }

    private void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject SimplePlatform;

        for(int i = 0; i < amountToPool; i++)
        {
            SimplePlatform = Instantiate(objectToPool);
            SimplePlatform.SetActive(false);
            pooledObjects.Add(SimplePlatform);
        }
    }

    public GameObject GetPooledObject()
    {
        for(int i = 0; i < amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}

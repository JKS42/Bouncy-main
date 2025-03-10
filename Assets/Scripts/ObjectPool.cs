using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

        InitiatePool();
    }
    [SerializeField]
    GameObject spawnable;
    int sizeOfPool = 10;
   List<GameObject> objects = new List<GameObject>();

    public void SpawnObjects(Vector3 position)
    {
        Debug.Log("error 001");
        var go = GetObject();
        Debug.Log("error 002");
        go.SetActive(true);
        Debug.Log("error 003");
        go.transform.position = position;
    }
    GameObject GetObject()
    {
        for (int i = 0; i < objects.Count - 1; i++)
        {
            if (!objects[i].activeInHierarchy)
            {
                return objects[i];
            }
                
        }
        sizeOfPool++;
        var go = Instantiate(spawnable);
        go.SetActive(false);
        objects.Add(go);
        return go;
    }
    void InitiatePool()
    {
        for (int i = 0; i < sizeOfPool; i++)
        {
            var go = Instantiate(spawnable);
            go.SetActive(false);
            objects.Add(go);
        }
    }
}

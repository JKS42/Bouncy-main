using UnityEngine;

public class BombSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject bomb;
    public const float maxTime = 5.0f;
    float currTime = 0.0f;
    [SerializeField]
    Transform SpawnLocation;
    int x = 0;
    int y = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        currTime -= Time.deltaTime;
        if (currTime <= 0.0f)
        {
            Reset();
            Spawn();
        }
    }
    void Reset()
    {
        currTime = maxTime;
    }
    void Spawn()
    {
        //Debug.Log("Spawn Called");
        //var go = Instantiate(bomb);
        //go.transform.position = SpawnLocation.position;

        ObjectPool.instance.SpawnObjects(SpawnLocation.position);
      
    }
}

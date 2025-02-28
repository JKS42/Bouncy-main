using UnityEngine;

public class ObsacleSpawner : MonoBehaviour
{
    [SerializeField]
    Transform Row1;
    [SerializeField]
    Transform Row2;

    public GameObject obstacle;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SpawnObstacle()
    {
        Instantiate(obstacle);
        var go = Instantiate(obstacle);
        go.transform.position = Row1.position;
        go.transform.rotation = Row1.rotation;

        Instantiate(obstacle);
        var go2 = Instantiate(obstacle);
        go.transform.position = Row2.position;
        go.transform.rotation = Row2.rotation;

        for(int i = 1; i < 10; i++)
        {
            var temp = Instantiate(obstacle);

            temp.transform.position = Row1.position;
            temp.transform.position += new Vector3(5 *i,0,0);
            temp.transform.rotation = Row1.rotation;

            var temp2 = Instantiate(obstacle);

            temp2.transform.position = Row2.position;
            temp2.transform.position += new Vector3(5*i, 0, 0);
            temp2.transform.rotation = Row2.rotation;
        }

    }
}

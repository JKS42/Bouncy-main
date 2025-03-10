using UnityEngine;

public class TurrentScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.LookAt(BallController.instance.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        BallController ball = other.gameObject.GetComponent<BallController>();
        if (ball != null)
        {
            ball.ChangeCheckPoint(transform.position);
        }
    }
}

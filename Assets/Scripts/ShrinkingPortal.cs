using UnityEngine;

public class ShrinkingPortal : MonoBehaviour
{
    [SerializeField]
    Portal otherPortal;
    [SerializeField]
    bool isON = true;
    float max = 1.0f;
    float min = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shrink();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (isON)
        {
            otherPortal.isON = false;
            if (collision.gameObject.GetComponent<BallController>() != null)
            {
                collision.gameObject.transform.position = otherPortal.transform.position;
            }

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isON = true;
    }
    void Shrink()
    {


        gameObject.transform.localScale = Vector3.Lerp(new Vector3(min, min, min), new Vector3(max, max, max), Mathf.PingPong(Time.time, 1));
        
        
    }
}

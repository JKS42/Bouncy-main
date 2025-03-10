using UnityEngine;

public class ShrinkingPortal : MonoBehaviour
{
    Portal portal;
    bool isOn = true;
    float max = 10.0f;
    float min = 0.01f;
    float stop = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // if (gameObject.transform.localScale = Vector3.Lerp(new Vector3(stop, stop, stop), new Vector3(stop, stop, stop), Mathf.PingPong(Time.time, 1){ }))

       
        //if (isOn)
        //{
        //    portal.isON = false;
        //    if(collision.gameObject.GetComponent<BallController>() != null)
        //        collision.gameObject.transform.position = portal.transform.position;
        //}
    }
    private void OnCollisionExit(Collision collision)
    {
        isOn = true;
    }
    void Shrink()
    {
        if(gameObject.transform.localScale.x < stop)
        {
            gameObject.transform.localScale = Vector3.Lerp(new Vector3(min, min, min), new Vector3(max, max, max), Mathf.PingPong(Time.time, 1));
        }
        
        
    }
}

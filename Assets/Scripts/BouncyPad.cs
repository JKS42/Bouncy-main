using UnityEngine;

public class BouncyPad : MonoBehaviour
{
    public float jumpForce = 25;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit");
        if(collision.gameObject.GetComponent<BallController>() != null)
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
        if (collision.gameObject.CompareTag("Player"))
        {

        }
        
    }
}

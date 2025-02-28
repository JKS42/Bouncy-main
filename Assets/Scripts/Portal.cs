using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    public Portal otherPortal;
    public bool isON = true;
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
        
        if(isON)
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
}

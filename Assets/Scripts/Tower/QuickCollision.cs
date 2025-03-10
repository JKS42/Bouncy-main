using UnityEngine;

public class QuickCollision : MonoBehaviour
{
    [SerializeField]
    Tower tower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //tower = GetComponent<Tower>();
        tower = GetComponentInParent<Tower>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<BallController>() != null)
        {
            tower.onDeadlyCollision();
        }
    }
}

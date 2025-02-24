using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    public bool mybool = false;
    float max = 10;
    float min = 0.1f;
    bool sizing = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.transform.Rotate(new Vector3(0,1,0));
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale = Vector3.Lerp(new Vector3(min, min, min), new Vector3(max, max, max), Mathf.PingPong(Time.time, 1));
        gameObject.transform.Rotate(new Vector3(0, 1, 0));
    }
}

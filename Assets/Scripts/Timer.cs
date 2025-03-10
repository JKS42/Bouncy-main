using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float currentTime;
    bool isRunning = false;
    [SerializeField]
    TextMeshProUGUI timeText;

    float addedminute = 60.0f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            currentTime += Time.deltaTime;

            VisualUpdates();
            minuteUpdate();
        }
            

    }

    void StopTime()
    {
        isRunning = false;
    }
    void StartTime()
    {
        currentTime = 0.0f;
        isRunning = true;


    }
    void VisualUpdates()
    {
        timeText.text = currentTime.ToString();
    }
    void minuteUpdate()
    {
        if(currentTime >= addedminute)
        {
            timeText.text = timeText.text + "";
        }
    }
}

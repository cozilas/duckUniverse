using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class timer : MonoBehaviour
{
    private TextMeshProUGUI timerr;
    private float startTime;
    private GameObject bathTriggerCheck;
  
    public void Start()
    {
        bathTriggerCheck = GameObject.Find("bath");
        startTime = Time.time;
        timerr = gameObject.GetComponent<TextMeshProUGUI>();
      }
    void Update()
    {

           if (bathTriggerCheck.GetComponent<bathBubbling>().sendSendtoTimer)
           {
            Destroy(GameObject.Find("Timer"));
            return;
           }
       
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f0");
        string miliseconds = ((t % 1).ToString()+"   ").Substring(2,2);

        timerr.SetText(" " + minutes + ":" + seconds + ":" + miliseconds);
    }
}


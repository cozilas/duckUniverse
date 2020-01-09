using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGameInstructions : MonoBehaviour
{
    GameObject startInstructions;
    private void Start()
    {
        startInstructions = GameObject.Find("startInstructions");
       // startInstructions.SetActive(true);
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            startInstructions.SetActive(false);
        }
    }
}
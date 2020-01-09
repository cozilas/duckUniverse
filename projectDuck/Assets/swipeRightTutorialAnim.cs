using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipeRightTutorialAnim : MonoBehaviour
{
    GameObject leftArrow;
    GameObject stomped;
    bool rightJump = true;
    bool leftJump = true;
    //bool stompedTime = false;
    private void Start()
    {
        leftArrow = GameObject.Find("leftArrow");
        leftArrow.SetActive(false);
        stomped = GameObject.Find("stompedButton");
        stomped.SetActive(false);
    }
    void Update()
    {
        if (GameObject.Find("ducky").GetComponent<playerControls>().jumpedRight == true && rightJump) 
        {
            StartCoroutine(waitToLandRight());           
        }
       
        if ((GameObject.Find("ducky").GetComponent<playerControls>().jumpedLeft == true)&& leftJump)
        {
            StartCoroutine(waitToLandLeft());
        }
        
     //   if (stomped == true && GameObject.Find("ducky").GetComponent<playerControls>().stomped)
      //  {
       //    stomped.SetActive(false);
     //   }
       
    }

    IEnumerator waitToLandRight()
    {
        yield return new WaitForSeconds(1.15f);
        Destroy(GameObject.Find("rightArrow"));
        leftArrow.SetActive(true);
        
    }
    IEnumerator waitToLandLeft()
    {
        yield return new WaitForSeconds(1.15f);
    
        leftArrow.SetActive(false);
    
        stomped.SetActive(true);
    }
}

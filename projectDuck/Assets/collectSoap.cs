using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class collectSoap : MonoBehaviour
{
    public bool soapCollected = false;

    GameObject soapParticles;
    GameObject soapCollectedImage;
    private void Start()
    {
        soapParticles = GameObject.Find("soapParticles");
        soapParticles.SetActive(false);

        soapCollectedImage = GameObject.Find("soapCollected");
        soapCollectedImage.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
        gameObject.GetComponent<AudioSource>().Play(0);
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        soapCollected = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        soapParticles.SetActive(true);
        soapCollectedImage.SetActive(true);
  
        StartCoroutine(textPopUp());
        gameObject.GetComponent<Light2D>().enabled = false;
    }
    private void Update()
    {
    
    }

     IEnumerator textPopUp()
    {
        yield return new WaitForSeconds(3.5f);
        soapCollectedImage.SetActive(false);

    }
}

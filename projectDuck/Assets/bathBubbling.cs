using UnityEngine;
using TMPro;


public class bathBubbling : MonoBehaviour
{
    public bool sendSendtoTimer = false;
   public bool checkForSoap = false;
    GameObject tutorialCanvas;
    GameObject endGameMenu;

    AudioSource audioMan;
    private void Start()
    {
        tutorialCanvas = GameObject.Find("tutorialAnimations");
        endGameMenu = GameObject.Find("endGameMenu");
        endGameMenu.SetActive(false);

        //find audio manager
        audioMan = GameObject.Find("audioManager").GetComponent<AudioSource>();
    }
    private void Update()
    {
        checkForSoap = GameObject.Find("soap").GetComponent<collectSoap>().soapCollected;
    }
    private void OnTriggerEnter2D(Collider2D other)
    { 

        audioMan.clip = GameObject.Find("audioManager").GetComponent<audioManager>().sounds[0];//add sounds    OF SPALSHING IN THE BATHTUB;
        audioMan.Play();

        sendSendtoTimer = true;
        if (checkForSoap)
        {
            gameObject.layer = 0;

            endGameMenu.SetActive(true);
            GameObject.Find("endTimeText").GetComponent<TextMeshProUGUI>().SetText(GameObject.Find("timer").GetComponent<TextMeshProUGUI>().text);

            GameObject.Find("bathBubblingParticles002").GetComponent<ParticleSystem>().Play();
            GameObject.Find("bathBubblingParticles003").GetComponent<ParticleSystem>().Play();
        }
        tutorialCanvas.SetActive(false);

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        gameObject.GetComponent<EdgeCollider2D>().enabled = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
       gameObject.GetComponent<EdgeCollider2D>().enabled = true;
        tutorialCanvas.SetActive(true);

    }
}

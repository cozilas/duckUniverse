using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneReset : MonoBehaviour
{
    Scene currentScene;
    public Vector2 resetTo;

    private void OnTriggerEnter2D(Collider2D player)
    {
        if(player.gameObject.tag == "Player")
        {
            GameObject.Find("ducky").transform.position = resetTo;
        }
    }
}

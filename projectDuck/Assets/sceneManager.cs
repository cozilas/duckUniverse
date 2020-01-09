using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneManager : MonoBehaviour
{
public void changeSceneTo(int sceneNumber)
    {
        Application.LoadLevel(sceneNumber);
    }
}

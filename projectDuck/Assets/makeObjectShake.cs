using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeObjectShake : MonoBehaviour
{
    int i = 0;
    private void Update()
    {
        if(i == 10)
        {
            i = 0;
        }
        if (i <= 5)
        {
            gameObject.transform.Rotate(0, 0, -1.5f);
            i++;
        }
        if (i >= 5)
        {
            gameObject.transform.Rotate(0, 0, 1.5f);
            i++;
        }
     
    }
 
}

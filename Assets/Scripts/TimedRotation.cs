using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedRotation : MonoBehaviour
{
    
 
 void Update()
    {
        float degreesPerSecond = 20;
       void Update()
        {
            transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
        }

    }
}
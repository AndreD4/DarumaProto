using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //

    void Start()
    {
        
    }

    void Update()
    {
        ProccessThrust();
        ProccessRotation();
    }

    void ProccessThrust()
    {
      if (Input.GetKey(KeyCode.Space))
      {
        Debug.Log("Pressed space");
      }
    }

    void ProccessRotation()
    {
      if (Input.GetKey(KeyCode.A))
      {
        Debug.Log("Rotate left");
      }
      
      else if (Input.GetKey(KeyCode.D))
      {
        Debug.Log("Rotate right");
      }
    }
}

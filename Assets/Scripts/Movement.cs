using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody myRigidbody;
    
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
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
        myRigidbody.AddRelativeForce(0,1,0);
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

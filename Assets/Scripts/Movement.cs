using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float thrustPower = 1f;
    [SerializeField] float rotationPower = 1f;
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
        myRigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * thrustPower);
      }
    }

    void ProccessRotation()
    {
      if (Input.GetKey(KeyCode.A))
      {
          transform.Rotate(Vector3.forward * Time.deltaTime * rotationPower);
      }
      
      else if (Input.GetKey(KeyCode.D))
      {
          transform.Rotate(-Vector3.forward * Time.deltaTime * rotationPower);
      }
    }
}

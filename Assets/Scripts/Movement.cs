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
        ProccessInput();
    }

    void ProccessInput()
    {
      if (Input.GetKey(KeyCode.Space))
      {
        Debug.Log("Pressed space");
      }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

    private bool callHelicopter = false;
    private Rigidbody rigidBody;
       
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public void OnCallHelicopter()
    {
        callHelicopter = true;
 
        rigidBody.velocity = new Vector3(0, 0, 50f); // Speed of Heli
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class PlayerController : MonoBehaviour {

    Rigidbody myRigidbody;
    Vector3 velocity;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody>();
	}

    // Update is called once per frame
    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    public void FixedUpdate()
    {
        myRigidbody.MovePosition(myRigidbody.position + velocity * Time.fixedDeltaTime);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackController : MonoBehaviour {

    private float moveForce = 170.0f;

    private Rigidbody myRigidbody;



    // Use this for initialization
    void Start () {

        this.myRigidbody = GetComponent<Rigidbody>();

        this.myRigidbody.AddForce(this.moveForce, 0, 0);

}
	
	// Update is called once per frame
	void Update () {
		
	}
}

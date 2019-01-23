using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float xForce = Input.GetAxis("Horizontal");
        float zForce = Input.GetAxis("Vertical");
        Vector3 Force = new Vector3(xForce, 0, zForce);
        rb.AddForce(Force);
    }
}
 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    private void OnTriggerEnter(Collider other)
    {
        //if other is tagged with bounce,
        if (other.gameObject.CompareTag("bounce"))
        {
            Vector3 Force = new Vector3(100, 1000, 0);
            rb.AddForce(Force);
        }
        //add force to player
    }
}

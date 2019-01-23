using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 playerPosition = Player.transform.position;
        transform.position = (new Vector3(playerPosition.x, transform.position.y, playerPosition.z - 5)); 
    }
}

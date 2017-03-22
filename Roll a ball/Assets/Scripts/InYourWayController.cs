using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InYourWayController : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// called when the Collider other enters the trigger.
	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);

		// lets deactivate instead
		if (other.gameObject.CompareTag("InYourWay")) {
			print ("hit");

		}
	}
}

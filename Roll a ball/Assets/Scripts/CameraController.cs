using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 cameraOffset;

	// Use this for initialization
	void Start () {
		cameraOffset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// follow cameras, procedural animations and last know positions,
	// LateUpdate is better than Update
	// runs when Update has run
	void LateUpdate() {
		//move camera with player
		transform.position  = player.transform.position + cameraOffset;	
	}

}

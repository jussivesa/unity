using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	public Text countText;
	public Text winText;
	private int count;
	private int collectablesCount;

	// runs at very first frame of the game
	void Start() {
		rb = GetComponent<Rigidbody>();
		count = 0;
		SetCountText ();
		winText.text = "";
		collectablesCount = GameObject.FindGameObjectsWithTag("PickUp").Length;
	}

	// rendered before every frame
	void Update() {
	}
		
	// just before every physics
	// any physics based code will go here
	void FixedUpdate() {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}

	// called when the Collider other enters the trigger.
	void OnTriggerEnter(Collider other) {
		//Destroy(other.gameObject);

		// lets deactivate instead
		if (other.gameObject.CompareTag("PickUp")) {
			other.gameObject.SetActive (false);
			count++;
			SetCountText ();
		}
	}

	void SetCountText() {
		countText.text = "Count: " + count.ToString ();
		//print ("count: " + count + " collectables: " + collectablesCount);
		if (count == collectablesCount) {
			winText.text = "You Win!";
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartScript : MonoBehaviour {

	public float speed = 1f;
	public bool levelBegin = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began || Input.GetKeyDown ("space")) {
			levelBegin = true;
		}

		if (levelBegin) {

			Vector3 movementDirection = new Vector3 (
				                           transform.forward.x,
				                           0,
				                           transform.forward.z
			                           );
			transform.position += movementDirection.normalized * speed * Time.deltaTime;
		}
	}

	void OnTriggerEnter(Collider collider) {

		if (collider.tag == "Checkpoint") {
			int checkpoint = int.Parse(collider.name);
		}
	}
}


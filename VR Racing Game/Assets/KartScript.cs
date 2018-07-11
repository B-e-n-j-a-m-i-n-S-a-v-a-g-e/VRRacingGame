using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartScript : MonoBehaviour {

	public float speed = 5f;
	//public bool levelBegin = false;

	private int currentCheckpoint;
	private int currentLap;

	public int CurrentLap { get { return currentLap;}}


	// Use this for initialization
	void Start () {
		currentCheckpoint = -1;
		currentLap = 0;
	}
	
	// Update is called once per frame
	void Update () {

			Vector3 movementDirection = new Vector3 (
				                           transform.forward.x,
				                           0,
				                           transform.forward.z
			                           );
			//transform.position += movementDirection.normalized * speed * Time.deltaTime;
		//transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
		transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
	}

	void OnTriggerEnter(Collider collider) {

		if (collider.tag == "Checkpoint") {
			int checkpoint = int.Parse(collider.name);

			if (checkpoint == currentCheckpoint + 1) {
				currentCheckpoint++;

				Debug.Log ("checkpoint: " + currentCheckpoint);
			}

			if (checkpoint == 0 && currentCheckpoint == 3) {
				currentCheckpoint = 0;
				currentLap++;

				Debug.Log ("New Lap!");
			}
		}
	}
}


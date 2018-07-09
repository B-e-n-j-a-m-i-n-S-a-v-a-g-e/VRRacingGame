using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public TextMesh infoText;
	public KartScript kart;
	private float timer;
	private float recordTime = 999;

	private int kartLap;

	// Use this for initialization
	void Start () {
		kartLap = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (kart.CurrentLap > kartLap) {
			kartLap = kart.CurrentLap;

			if (timer > recordTime) {
				recordTime = timer;
			}

			timer = 0;
		}

		infoText.text = "Time: " + Mathf.Floor(timer);
		if (recordTime < 999) {
			infoText.text += "\nRecord: " + Mathf.Floor(recordTime);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBy : MonoBehaviour {

	public GameObject zimmerImage;
	private bool flyTime;
	private int steps;

	public void goTime(){
		flyTime = true;
		zimmerImage.transform.position = new Vector3 (-226f, 223f, -50f);
	}

	// Use this for initialization
	void Start () {
		flyTime = false;
		steps = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (flyTime || (zimmerImage.transform.position.x < 1213 && zimmerImage.transform.position.x > -226)) {
			float step = Time.deltaTime;
			zimmerImage.transform.position += new Vector3 (3000f * step, 0f, 0f);
			steps++;
		}
		if (steps > 200 || zimmerImage.transform.position.x > 10000) {
			flyTime = false;
			steps = 0;
		}
	}
}

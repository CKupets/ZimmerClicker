using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabManager : MonoBehaviour {

	public GameObject secondPanel;
	public GameObject clickPanel;

	public void showSecondPanel(){
		clickPanel.SetActive (false);
		secondPanel.SetActive (true);
	}

	public void showClickPanel(){
		clickPanel.SetActive (true);
		secondPanel.SetActive (false);
	}

	// Use this for initialization
	void Start () {
		showClickPanel ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour {

	public GameObject SayHi;
	public GameObject layerOneYes;
	public GameObject layerOneNo;
	public GameObject layerOneText;
	public GameObject zimmerImage;

	public void SayHiFunction(){
		SayHi.SetActive (false);
		layerOneNo.SetActive(true);
		layerOneText.SetActive(true);
		layerOneYes.SetActive(true);
	}

	public void yes(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("MainClickerScreen");
	}

	public void no(){
		StartCoroutine (zimmerBigger ());
	}

	IEnumerator zimmerBigger(){
		int i = 0;
		int freq = 10;
		while (i < freq) {
			zimmerImage.transform.localScale += new Vector3 (0.1f/freq, 0.1f/freq, 0);
			yield return new WaitForSecondsRealtime (1 / freq);
			i++;
		}
		yield break;
	}

	// Use this for initialization
	void Start () {
		layerOneNo.SetActive(false);
		layerOneText.SetActive(false);
		layerOneYes.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
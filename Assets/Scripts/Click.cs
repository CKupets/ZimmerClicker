using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

	public UnityEngine.UI.Text endowmentDisplay;
	public UnityEngine.UI.Text perClickIncome;
	public double endowment = 0;
	public double addPerClick = 74526;

	public FlyBy flyby;
	public float clicksPerSecond;
	private List<float> clicks = new List<float> ();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		foreach(float timef in clicks) {
			if (Time.time - timef > 2f) {
				clicks.Remove (timef);
			}
		}
		endowmentDisplay.text = "Endowment: $" + endowment.ToString("N");
		clicksPerSecond = (clicks.Count / 2f);
		perClickIncome.text = "Per Click Income: $" + addPerClick.ToString ("N") + "\nClicksPerSecond: " +clicksPerSecond.ToString("####.#");
	}

	public void Clicked(){
		endowment += addPerClick;
		GetComponent<AudioSource>().Play ();
		flyby.goTime ();
		clicks.Add (Time.time);
	}
}

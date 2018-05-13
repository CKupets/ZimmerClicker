using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerSec : MonoBehaviour {

	public UnityEngine.UI.Text PSDisplay;
	public Click click;
	public ItemManager[] items;

	private float frequency = 10;

	public double getPerSecIncome(){
		double tick = 0;
		foreach (ItemManager item in items) {
			tick += item.count * item.tickValue;
		}
		return tick;
	}

	public void AutoPerSec(){
		click.endowment += 100 * (int)((getPerSecIncome ())/frequency);
	}

	IEnumerator AutoTick(){
		while (true) {
			AutoPerSec ();
			yield return new WaitForSeconds (1f/frequency);
		}
	}

	// Use this for initialization
	void Start () {
		//StartCoroutine (AutoTick ());
	}
	
	// Update is called once per frame
	void Update () {
		PSDisplay.text = "$" + getPerSecIncome ().ToString("N") + "/sec";

		click.endowment += ((getPerSecIncome ()) * Time.deltaTime);

	}
}

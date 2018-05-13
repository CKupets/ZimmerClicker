using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {

	public Click click;
	public UnityEngine.UI.Text itemInfo;
	public double cost;
	public int count = 0;
	public double clickPower;
	public string itemName;
	private double baseCost;

	// Use this for initialization
	void Start () {
		baseCost = cost;
	}
	
	// Update is called once per frame
	void Update () {
		itemInfo.text = itemName + " (" + count + ")" + "\nCost: $" + cost.ToString("N") + "\nPower: +$" + clickPower.ToString("N");
	}

	public void PurchasedUpgrade(){
		if (click.endowment >= cost) {
			click.endowment -= (cost);
			count++;
			click.addPerClick += clickPower;
			cost = (baseCost * Mathf.Pow (1.15f, count));
			GetComponents<AudioSource> () [0].Play ();
		} else {
			GetComponents<AudioSource>()[1].Play ();
		}
	}
}

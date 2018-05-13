using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour {

	public UnityEngine.UI.Text itemInfo;
	public Click click;
	public double cost;
	public double tickValue;
	public int count;
	public string itemName;
	private double baseCost;

	// Use this for initialization
	void Start () {
		baseCost = cost;
	}
	
	// Update is called once per frame
	void Update () {
		itemInfo.text = itemName + " (" + count + ")" + "\nCost: $" + cost.ToString ("N") + "\nAdded Income: $" + tickValue.ToString ("N") + "/s";
	}

	public void PurchasedItem(){
		if (click.endowment >= cost) {
			click.endowment -= (cost);
			count++;
			cost = (baseCost * Mathf.Pow (1.15f, count));
			GetComponents<AudioSource> () [0].Play ();
		} else {
			GetComponents<AudioSource> () [1].Play ();
		}
	}

}

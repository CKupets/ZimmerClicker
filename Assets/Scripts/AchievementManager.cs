using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour {

	public Click click;
	public PerSec persec;

	private float startTime;

	public UnityEngine.UI.Button achievement1;
	public UnityEngine.UI.Button achievement2;
	public UnityEngine.UI.Button achievement3;
	public UnityEngine.UI.Button achievement4;
	public UnityEngine.UI.Button achievement5;
	public UnityEngine.UI.Button achievement6;
	public UnityEngine.UI.Button achievement7;
	public UnityEngine.UI.Button achievement8;
	public UnityEngine.UI.Button achievement9;
	public UnityEngine.UI.Button achievement10;
	public UnityEngine.UI.Button achievement11;

	bool get1;
	bool get2;
	bool get3;
	bool get4;
	bool get5;
	bool get6;
	bool get7;
	bool get8;
	bool get9;
	bool get10;
	bool get11;

	public void achieved(UnityEngine.UI.Button input){
		UnityEngine.UI.Button button = input.GetComponent ("Button") as UnityEngine.UI.Button;
		UnityEngine.UI.ColorBlock colorblock = new UnityEngine.UI.ColorBlock ();
		colorblock.normalColor = new Color (255f, 215f, 0f, 1.0f);
		colorblock.pressedColor = new Color (255f, 215f, 0f, 1.0f);
		colorblock.disabledColor = new Color (255f, 215f, 0f, 1.0f);
		colorblock.highlightedColor = new Color (255f, 215f, 0f, 1.0f);
		colorblock.colorMultiplier = 1f;
		button.colors = colorblock;
		UnityEngine.UI.Image image = input.GetComponent ("Image") as UnityEngine.UI.Image;
		image.color = new Color (255f, 215f, 0f, 1.0f);

		UnityEngine.UI.Text text = input.GetComponentInChildren<UnityEngine.UI.Text> ();
		text.color = new Color (0f, 0f, 0f, 1f);

		GetComponent<AudioSource>().Play ();
	}

	// Use this for initialization
	void Start () {
		get1 = false;
		get2 = false;
		get3 = false;
		get4 = false;
		get5 = false;
		get6 = false;
		get7 = false;
		get8 = false;
		get9 = false;
		get10 = false;
		get11 = false;
		startTime = Time.time;
	}

	public void achv10(){
		if (!get11) {
			achieved (achievement11);
			GetComponent<AudioSource>().Play ();
			get11 = true;
		}
	}

	// Update is called once per frame
	void Update () {
		if (!get1) {
			if (click.endowment > 7820000000) {
				achieved (achievement1);
				get1 = true;
			}
		}
		if (!get2) {
			if (click.endowment > 0) {
				achieved (achievement2);
				get2 = true;
			}
		}
		if (!get3) {
			if (click.clicksPerSecond > 12.5) {
				achieved (achievement3);
				get3 = true;
			}
		}
		if (!get4) {
			if (click.endowment > 37600000000) {
				achieved (achievement4);
				get4 = true;
			}
		}
		if (!get5) {
			if (persec.items[0].count > 99) {
				achieved (achievement5);
				get5 = true;
			}
		}
		if (!get6) {
			if (click.endowment > 1000000000 && persec.getPerSecIncome() < 1) {
				achieved (achievement6);
				get6 = true;
			}
		}
		if (!get7) {
			if (click.endowment < 0) {
				achieved (achievement7);
				get7 = true;
			}
		}
		if (!get8) {
			if (Time.time - startTime > 3600) {
				achieved (achievement8);
				get8 = true;
			}
		}
		if (!get9) {
			if (Time.time - startTime > 30 && click.endowment == 0) {
				achieved (achievement9);
				get9 = true;
			}
		}
	}
}

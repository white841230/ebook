using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using waqashaxhmi.AndroidNativePlugin;
using System.IO;
using UnityEngine.Sprites;

public class changeoutsidekind : MonoBehaviour {
	public Sprite temp;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void changeoukind()
	{
		if (gameObject.name == "xoliat") {
			GameObject.Find ("outsidesuit").GetComponent<Image> ().sprite = null;
		} else {
			//Texture2D tex = gameObject.GetComponent<Image> ().sprite.texture;
			//temp = Sprite.Create (tex, new Rect (0, 0, tex.width, tex.height), new Vector2 (0, 0));
			//GameObject.Find ("outsidesuit").GetComponent<Image> ().sprite = temp;
			GameObject.Find ("outsidesuit").GetComponent<Image> ().sprite = gameObject.GetComponent<Image> ().sprite;
			//GameObject.Find ("outsidesuit").GetComponent<Image> ().color = Color.white;
		}
	}
}

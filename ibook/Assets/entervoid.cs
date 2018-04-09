using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class entervoid : MonoBehaviour {
	public GameObject bkt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		bkt = GameObject.Find ("bktext2");
	}
	public void entervoidtext()
	{
		if (gameObject.name == "Buttonvoid0") {
			bkt.GetComponent<UnityEngine.UI.Text> ().text = "";
		} else {
			bkt.GetComponent<UnityEngine.UI.Text> ().text = gameObject.GetComponentInChildren<UnityEngine.UI.Text> ().text;
		}
		}
}

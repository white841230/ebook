using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Sprites;

public class rn2 : MonoBehaviour {
	public GameObject rn;
	public GameObject esm;
	public static int x;
	public static int gab1=0;
	public int i;
	public int y;
	public static GameObject gabb;
	// Use this for initialization
	void Start () {
		//gabb ;
		x = 1;
		if (gab1 == 0) {
			gabb = GameObject.Find ("PAGE1");
			gab1 = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		y = x;
		gameObject.GetComponent<Image>().sprite = GameObject.Find("bookbkimage"+Convert.ToInt32(gameObject.GetComponentInChildren<UnityEngine.UI.Text> ().text)).GetComponent<Image>().sprite;
		rn.transform.localPosition = gabb.transform.localPosition;
	}
	public void rightnow2(){
		gabb = gameObject;
		//rn.transform.localPosition = gameObject.transform.localPosition;
		//rn.transform.parent = gameObject.transform;
		x = Convert.ToInt32(gameObject.GetComponentInChildren<UnityEngine.UI.Text> ().text);
		for (i = 1; i <= reset.pagenum; i++) {
			esm = GameObject.Find ("bookbkimage" + i);
			if (i == x) {
				esm.transform.parent = GameObject.Find ("editcanvas").transform;
			}else{
				esm.transform.parent = GameObject.Find ("bookbkimagecanvas").transform;
			}
		}
	}
}

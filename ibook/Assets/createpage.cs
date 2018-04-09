using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;
using System;

public class createpage : MonoBehaviour {
	public GameObject ispage;
	public GameObject newpage;
	public GameObject ispage2;
	public GameObject newpage2;
	public GameObject newrn;
	public GameObject newrn2;
	public int num;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		num = reset.pagenum;
	}
	public void creatingpage(){
		newpage = Instantiate (ispage);
		newpage.transform.parent = GameObject.Find ("makepage").transform;
		newpage.transform.localScale = new Vector3 (1f, 1f, 1f);
		newpage.transform.localPosition = new Vector3 (ispage.transform.localPosition.x, ispage.transform.localPosition.y-260, 0);
		reset.pagenum = reset.pagenum + 1;
		newpage.name = ("PAGE" + reset.pagenum);
		newpage.GetComponentInChildren<UnityEngine.UI.Text> ().text = ""+reset.pagenum;
		ispage = newpage;
		GameObject.Find ("rnn" + (reset.pagenum-1)).transform.parent = GameObject.Find ("Main Camera").transform;
		newpage2 = Instantiate (ispage2);
		GameObject.Find ("rnn" + (reset.pagenum-1)).transform.parent = ispage2.transform;
		newpage2.transform.parent = GameObject.Find ("bookbkimagecanvas").transform;
		newpage2.transform.localScale = new Vector3 (0.6f, 0.6f, 1f);
		newpage2.transform.localPosition = new Vector3 (ispage2.transform.localPosition.x, ispage2.transform.localPosition.y, 0);
		newpage2.name = ("bookbkimage" + reset.pagenum);
		newpage2.GetComponent<Image> ().sprite = null;
		ispage2 = newpage2;
		newrn = Instantiate (GameObject.Find("rnn" + (reset.pagenum-1)));
		newrn.transform.parent = GameObject.Find("bookbkimage" + reset.pagenum).transform;
		newrn.transform.localScale = GameObject.Find ("rnn" + (reset.pagenum-1)).transform.localScale;
		newrn.transform.localPosition = GameObject.Find ("rnn" + (reset.pagenum-1)).transform.localPosition;
		newrn.name = ("rnn" + reset.pagenum);


	}
}
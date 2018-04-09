using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makemaker : MonoBehaviour {
	public int makernum=0;
	public GameObject makingmaker;
	public static int mkstmk;
	public GameObject usermaker;
	public int i;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (makernum >= 3) {
			rool2.bkmopen = 1;
		} else {
			rool2.bkmopen = 0;
		}
	}
	public void makemak()
	{
		if (makernum < 1) {
			makernum = 1;
		}
		if (makernum >= 1 && makernum <5) {
			usermaker = GameObject.Find ("maker" + makernum);
			makernum = makernum + 1;
			makingmaker = Instantiate (usermaker);
			makingmaker.transform.parent = GameObject.Find("bookface").transform; 
			makingmaker.transform.localScale = new Vector3 (1f, 1f, 1f);
			makingmaker.name = ("maker" + makernum);
			makingmaker.transform.localPosition = new Vector3 (usermaker.transform.localPosition.x+60,-240,0);
			for (i = 1; i < makernum; i++) {
				GameObject.Find("maker" + i).transform.localPosition = new Vector3 (GameObject.Find("maker" + i).transform.localPosition.x - 60, -240, 0);
			}
			makernum = makernum - 1;
			usermaker = GameObject.Find ("mkimage" + makernum);
			makernum = makernum + 1;
			makingmaker = Instantiate (usermaker);
			makingmaker.transform.parent = GameObject.Find("bookmaker").transform; 
			makingmaker.transform.localScale = new Vector3 (1f, 1f, 1f);
			makingmaker.name = ("mkimage" + makernum);
			makingmaker.transform.localPosition = new Vector3 (837,usermaker.transform.localPosition.y-236,0);
		}
		mkstmk = makernum;
	}
}

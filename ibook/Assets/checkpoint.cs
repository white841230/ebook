using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour {
	public GameObject rn;
	public static GameObject isme;
	public static GameObject isus;
	public int i;
	public GameObject ttx;
	// Use this for initialization
	void Start () {
		isme = GameObject.Find ("mkimage1");
		isus = GameObject.Find ("maker1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void rightnoww(){
		if (isme == gameObject) {
			ttx.SetActive(true);
		}
		rn.transform.localPosition = gameObject.transform.localPosition;
		isme = gameObject;
		for (i = 1; i < 6; i++) {
			if (isme.name == "mkimage" + i) {
				isus = GameObject.Find ("maker" + i);
			}
		}
	}
}

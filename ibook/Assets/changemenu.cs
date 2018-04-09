using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changemenu : MonoBehaviour {
	public static int controlsuit;
	public GameObject imagemenu1;
	public GameObject imagemenu2;
	public GameObject imagemenubt;
	public GameObject bkname;
	public GameObject bkmaker;
	public GameObject bkmaker2;
	public GameObject CHSU;
	public static int suttef;
	public static int suttef2;
	public GameObject bkvoid;
	// Use this for initialization
	void Start () {
		controlsuit = 0;
		suttef = 0;
		suttef2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void chbookimage(){
		controlsuit = 1;
		imagemenu1.SetActive (true);
		imagemenu2.SetActive (true);
		imagemenubt.SetActive (true);
		bkname.SetActive (false);
		bkmaker.SetActive (false);
		bkmaker2.SetActive (false);
		CHSU.SetActive (false);
		changemenu.suttef = 0;
		changemenu.suttef2 = 0;
		bkvoid.SetActive (false);
	}
	public void chbookname(){
		if (CHANGEUPDOWN.upanddown == 0) {
			controlsuit = 1;
			imagemenu1.SetActive (false);
			imagemenu2.SetActive (false);
			bkname.SetActive (true);
			bkmaker.SetActive (false);
			bkmaker2.SetActive (false);
			imagemenubt.SetActive (false);
			CHSU.SetActive (false);
			changemenu.suttef = 0;
			changemenu.suttef2 = 0;
			bkvoid.SetActive (false);
		}
		if (CHANGEUPDOWN.upanddown == 1) {
			controlsuit = 1;
			imagemenu1.SetActive (true);
			imagemenu2.SetActive (true);
			imagemenubt.SetActive (true);
			bkname.SetActive (false);
			bkmaker.SetActive (false);
			bkmaker2.SetActive (false);
			CHSU.SetActive (false);
			suttef = 1;
			changemenu.suttef2 = 0;
			bkvoid.SetActive (false);
		}
	}
	public void chbookmaker(){
		if (CHANGEUPDOWN.upanddown == 0) {
			controlsuit = 2;
			imagemenu1.SetActive (false);
			imagemenu2.SetActive (false);
			bkname.SetActive (false);
			bkmaker.SetActive (true);
			bkmaker2.SetActive (true);
			imagemenubt.SetActive (true);
			CHSU.SetActive (false);
			changemenu.suttef = 0;
			changemenu.suttef2 = 0;
			bkvoid.SetActive (false);
		}
		if (CHANGEUPDOWN.upanddown == 1) {
			controlsuit = 1;
			imagemenu1.SetActive (false);
			imagemenu2.SetActive (false);
			bkname.SetActive (false);
			bkmaker.SetActive (false);
			bkmaker2.SetActive (false);
			imagemenubt.SetActive (false);
			CHSU.SetActive (false);
			changemenu.suttef = 0;
			changemenu.suttef2 = 1;
			bkvoid.SetActive (true);
		}
	}
	public void chbookSU(){
		controlsuit = 1;
		imagemenu1.SetActive (false);
		imagemenu2.SetActive (false);
		bkname.SetActive (false);
		bkmaker.SetActive (false);
		bkmaker2.SetActive (false);
		imagemenubt.SetActive (false);
		CHSU.SetActive (true);
		changemenu.suttef = 0;
		changemenu.suttef2 = 0;
		bkvoid.SetActive (false);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bookface : MonoBehaviour {
	public GameObject bf;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void cbf(){
		if (CHANGEUPDOWN.upanddown == 0 && changemenu.suttef==0) {
			if (gameObject.name == "0") {
				bf = GameObject.Find ("bfupimage");
				bf.GetComponent<Image> ().sprite = null;
			} else {
				bf = GameObject.Find ("bfupimage");
				bf.GetComponent<Image> ().sprite = gameObject.GetComponent<Image> ().sprite;
			}
		}
		if (CHANGEUPDOWN.upanddown == 1 && changemenu.suttef==0) {
			if (gameObject.name == "0") {
				bf = GameObject.Find ("dwonimage");
				bf.GetComponent<Image> ().sprite = null;
			} else {
				bf = GameObject.Find ("dwonimage");
				bf.GetComponent<Image> ().sprite = gameObject.GetComponent<Image> ().sprite;
			}
		}
		if (CHANGEUPDOWN.upanddown == 1 && changemenu.suttef==1) {
			if (gameObject.name == "0") {
				bf = GameObject.Find ("dwoncenterimage");
				bf.GetComponent<Image> ().sprite = null;
			} else {
				bf = GameObject.Find ("dwoncenterimage");
				bf.GetComponent<Image> ().sprite = gameObject.GetComponent<Image> ().sprite;
			}
		}
	}
	public void cbk(){
		if (gameObject.name == "0") {
			GameObject.Find ("bookbkimage" + rn2.x).GetComponent<Image> ().sprite = null;
		} else {
			GameObject.Find ("bookbkimage" + rn2.x).GetComponent<Image> ().sprite = gameObject.GetComponent<Image> ().sprite;
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changemove : MonoBehaviour {
	public int cmove;
	public int i;
	public static GameObject cmv;
	public GameObject ccmv;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ccmv = cmv;
	}
	public void changemovee(int n){
		if (rn3.runmove == 0) {
			cmv.GetComponent<rn3> ().move = n;
			rn3.runmove = 1;
			Debug.Log (rn3.runmove);
		}
		if (n == 0) {
			changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "0";
			cmv.GetComponent<rn3> ().movetime = 3;
		}
	}
	public void changemoveetime(int n){
		if (rn3.runmove == 0) {
			cmv.GetComponent<rn3> ().movetime = n;
			cmv.GetComponent<rn3> ().move = cmv.GetComponent<rn3> ().lmove;
			rn3.runmove = 1;
			Debug.Log (rn3.runmove);
		}
	}
}

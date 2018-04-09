using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goanywhere : MonoBehaviour {
	public int i;
	public int j;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void gohome(){
		bookname.bkname = "";
		Destroy(GameObject.Find("resetvile"));
		Destroy(GameObject.Find("resetvile2"));
		Application.LoadLevel(0);
	}
	public void gobox(){
		Application.LoadLevel(1);
	}
	public void gomake(){
		Application.LoadLevel(2);
	}
	public void library(){
		Application.LoadLevel(5);
	}
	public void readbook(){
		Application.LoadLevel(6);
	}
	public void saystory(){
		
		bookname.bkname = GameObject.Find ("bktext").GetComponent<UnityEngine.UI.Text> ().text;
		Application.LoadLevel(3);
	}
	public void putimage(){
		Destroy(GameObject.Find("makepage2"));
		reset2.kabb = 0;
		Application.LoadLevel(4);
	}
	public void gotos7(){
		reset2.kabb = 0;
		reset2.ss = 7;
		Application.LoadLevel(7);
		for (i = 1; i <= rn3.g; i++) {
			GameObject.Find ("clone" + i).GetComponent<roolimage> ().enabled = false;
			GameObject.Find ("clone" + i).GetComponent<ROOL3> ().enabled = false;
		}
		for (j = 1; j <= reset.pagenum; j++) {
			//GameObject.Find ("rnn" + j).GetComponent<roolimage> ().enabled = false;
			GameObject.Find ("rnn" + j).GetComponent<ROOL3> ().enabled = false;
		}
	}
	public void gotos8(){
		for (i = 1; i <= rn3.g; i++) {
			GameObject.Find ("clone" + i).GetComponent<Animator>().runtimeAnimatorController = Resources.Load("chanpage") as RuntimeAnimatorController;
		}
		reset2.kabb = 0;
		reset2.ss = 8;
		Application.LoadLevel(8);
		for (i = 1; i <= rn3.g; i++) {
			GameObject.Find ("clone" + i).GetComponent<roolimage> ().enabled = false;
			GameObject.Find ("clone" + i).GetComponent<ROOL3> ().enabled = false;
			GameObject.Find ("clone" + i).GetComponent<rn3> ().enabled = false;
		}
		for (j = 1; j <= reset.pagenum; j++) {
			//GameObject.Find ("rnn" + j).GetComponent<roolimage> ().enabled = false;
			GameObject.Find ("rnn" + j).GetComponent<ROOL3> ().enabled = false;
			GameObject.Find ("rnn" + j).SetActive (false);
		}
	}
}

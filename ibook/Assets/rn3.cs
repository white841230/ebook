using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Sprites;

public class rn3 : MonoBehaviour {
	public GameObject rn;
	public GameObject rnz;
	public GameObject esm;
	public GameObject cesm;
	public static GameObject gabbb;
	public static int gabbb1;
	public static int g;
	public int move;
	public float gblapos;
	public float gblapos2;
	public int lmove;
	public int i;
	public int y;
	public int pass=0;
	public new Vector3 poss;
	public static int runmove = 0;
	public int movetime = 3;
	public int rm;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		rm = runmove;
		y = g;
		rn = GameObject.Find ("rn3");
		rnz = GameObject.Find ("rnn" + rn2.x);
		//gameObject.GetComponent<Image>().sprite = GameObject.Find("bookbkimage"+Convert.ToInt32(gameObject.GetComponentInChildren<UnityEngine.UI.Text> ().text)).GetComponent<Image>().sprite;
		if (move == 1&&runmove==1) {
			GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
			changemove.cmv.transform.Translate(Vector2.up * Time.deltaTime * 350f/movetime);
				if (pass == 0) {
				gblapos = changemove.cmv.transform.localPosition.y;
					pass = 1;
				Debug.Log (pass);
				}
			if (changemove.cmv.transform.localPosition.y >= gblapos+350 && pass == 1) {
				changemove.cmv.transform.Translate(Vector2.up * Time.deltaTime * 0f);
				changemove.cmv.transform.localPosition = new Vector3 (changemove.cmv.transform.localPosition.x, gblapos, 0f);
					lmove = 1;
					pass = 0;
				Debug.Log (pass);
				runmove = 0;
				Debug.Log (runmove);
				move = 0;
				GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
				if (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text == "") {
					changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
				}
				}
			}
		if (move == 2&&runmove==1) {
			GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
			changemove.cmv.transform.Translate(Vector2.down * Time.deltaTime * 350f/movetime);
				if (pass == 0) {
				gblapos = changemove.cmv.transform.localPosition.y;
					pass = 1;
				Debug.Log (pass);
				}
			if (changemove.cmv.transform.localPosition.y <= gblapos-350&&pass==1) {
				changemove.cmv.transform.Translate(Vector2.down * Time.deltaTime * 0f);
				changemove.cmv.transform.localPosition = new Vector3 (changemove.cmv.transform.localPosition.x, gblapos, 0f);
					lmove = 2;
					pass = 0;
				Debug.Log (pass);
				runmove = 0;
				Debug.Log (runmove);
				move = 0;
				GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
				if (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text == "") {
					changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
				}
				}
			}
		if (move == 3&&runmove==1) {
			GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
			changemove.cmv.transform.Translate(Vector2.left * Time.deltaTime * 350f/movetime);
				if (pass == 0) {
				gblapos = changemove.cmv.transform.localPosition.x;
					pass = 1;
				Debug.Log (pass);
				}
			if (changemove.cmv.transform.localPosition.x <= gblapos-350&&pass == 1) {
				changemove.cmv.transform.Translate(Vector2.left * Time.deltaTime * 0f);
				changemove.cmv.transform.localPosition = new Vector3 (gblapos, changemove.cmv.transform.localPosition.y, 0f);
					lmove = 3;
					pass = 0;
				Debug.Log (pass);
				runmove = 0;
				Debug.Log (runmove);
				move = 0;
				GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
				if (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text == "") {
					changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
				}
				}
			}
		if (move == 4&&runmove==1) {
			GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
			changemove.cmv.transform.Translate(Vector2.right * Time.deltaTime * 350f/movetime);
				if (pass == 0) {
				gblapos = changemove.cmv.transform.localPosition.x;
					pass = 1;
				Debug.Log (pass);
				}
			if (changemove.cmv.transform.localPosition.x >= gblapos+350&&pass == 1) {
				changemove.cmv.transform.Translate(Vector2.right * Time.deltaTime * 0f);
				changemove.cmv.transform.localPosition = new Vector3 (gblapos, changemove.cmv.transform.localPosition.y, 0f);
					lmove = 4;
					pass = 0;
				Debug.Log (pass);
				runmove = 0;
				Debug.Log (runmove);
				move = 0;
				GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
				if (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text == "") {
					changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
				}
				}
			}
		if (move == 5&&runmove==1) {
			GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
			changemove.cmv.transform.Translate(Vector2.left* Time.deltaTime * 350f/movetime);
			changemove.cmv.transform.Translate(Vector2.up * Time.deltaTime * 350f/movetime);
			if (pass == 0) {
				gblapos = changemove.cmv.transform.localPosition.x;
				gblapos2 = changemove.cmv.transform.localPosition.y;
				poss = changemove.cmv.transform.localPosition;
				pass = 1;
				Debug.Log (pass);
			}
			if (Vector3.Distance( poss, gameObject.transform.localPosition ) >= 350&&pass == 1) {
				changemove.cmv.transform.Translate(Vector2.left* Time.deltaTime * 0f);
				changemove.cmv.transform.Translate(Vector2.up * Time.deltaTime * 0f);
				changemove.cmv.transform.localPosition = poss;
				//new Vector3 (gblapos, gblapos2, 0f)
				lmove = 5;
				pass = 0;
				Debug.Log (pass);
				runmove = 0;
				Debug.Log (runmove);
				move = 0;
				GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
				if (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text == "") {
					changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
				}
			}
		}
		if (move == 6&&runmove==1) {
			GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
			changemove.cmv.transform.Translate(Vector2.right* Time.deltaTime * 350f/movetime);
			changemove.cmv.transform.Translate(Vector2.up * Time.deltaTime * 350f/movetime);
			if (pass == 0) {
				gblapos = changemove.cmv.transform.localPosition.x;
				gblapos2 = changemove.cmv.transform.localPosition.y;
				poss = changemove.cmv.transform.localPosition;
				pass = 1;
				Debug.Log (pass);
			}
			if (Vector3.Distance( poss, gameObject.transform.localPosition ) >= 350&&pass == 1) {
				changemove.cmv.transform.Translate(Vector2.right* Time.deltaTime * 0f);
				changemove.cmv.transform.Translate(Vector2.up * Time.deltaTime * 0f);
				changemove.cmv.transform.localPosition = poss;
				//new Vector3 (gblapos, gblapos2, 0f)
				lmove = 6;
				pass = 0;
				Debug.Log (pass);
				runmove = 0;
				Debug.Log (runmove);
				move = 0;
				GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
				if (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text == "") {
					changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
				}
			}
		}
		if (move == 7&&runmove==1) {
			GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
			changemove.cmv.transform.Translate(Vector2.left* Time.deltaTime * 350f/movetime);
			changemove.cmv.transform.Translate(Vector2.down * Time.deltaTime * 350f/movetime);
			if (pass == 0) {
				gblapos = changemove.cmv.transform.localPosition.x;
				gblapos2 = changemove.cmv.transform.localPosition.y;
				poss = changemove.cmv.transform.localPosition;
				pass = 1;
				Debug.Log (pass);
			}
			if (Vector3.Distance( poss, gameObject.transform.localPosition ) >= 350&&pass == 1) {
				changemove.cmv.transform.Translate(Vector2.left* Time.deltaTime * 0f);
				changemove.cmv.transform.Translate(Vector2.down * Time.deltaTime * 0f);
				changemove.cmv.transform.localPosition = poss;
				//new Vector3 (gblapos, gblapos2, 0f)
				lmove = 7;
				pass = 0;
				Debug.Log (pass);
				runmove = 0;
				Debug.Log (runmove);
				move = 0;
				GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
				if (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text == "") {
					changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
				}
			}
		}
		if (move == 8&&runmove==1) {
			GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
			changemove.cmv.transform.Translate(Vector2.right* Time.deltaTime * 350f/movetime);
			changemove.cmv.transform.Translate(Vector2.down * Time.deltaTime * 350f/movetime);
			if (pass == 0) {
				gblapos = changemove.cmv.transform.localPosition.x;
				gblapos2 = changemove.cmv.transform.localPosition.y;
				poss = changemove.cmv.transform.localPosition;
				pass = 1;
				Debug.Log (pass);
			}
			if (Vector3.Distance( poss, gameObject.transform.localPosition ) >= 350&&pass == 1) {
				changemove.cmv.transform.Translate(Vector2.right* Time.deltaTime * 0f);
				changemove.cmv.transform.Translate(Vector2.down * Time.deltaTime * 0f);
				changemove.cmv.transform.localPosition = poss;
				//new Vector3 (gblapos, gblapos2, 0f)
				lmove = 8;
				pass = 0;
				Debug.Log (pass);
				runmove = 0;
				Debug.Log (runmove);
				move = 0;
				GameObject.Find ("rnn" + rn2.x).transform.localPosition = changemove.cmv.transform.localPosition;
				if (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text == "") {
					changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
				}
			}
		}
	}
	public void rightnow3(){
		if (rn.transform.localPosition == gameObject.transform.localPosition &&gameObject.transform.parent.name!="bookbkimage"+rn2.x) {
			cesm = Instantiate (esm);
			cesm.transform.parent = GameObject.Find ("bookbkimage"+rn2.x).transform;
			cesm.transform.localScale = new Vector3 (3f, 3f, 0);
			cesm.transform.localPosition = new Vector3 (0, 0, 0);
			g = g + 1;
			cesm.name = ("clone"+g);
			cesm.GetComponent<rool2> ().enabled = false;
			cesm.GetComponent<roolimage> ().enabled = true;
			cesm.GetComponent<ROOL3> ().enabled = true;
			cesm.GetComponent<rn3> ().enabled = true;
	
		}
		if(rn.transform.localPosition != gameObject.transform.localPosition&&gameObject.transform.parent.name!="bookbkimage"+rn2.x)
		rn.transform.localPosition = gameObject.transform.localPosition;
		if(rnz.transform.localPosition != gameObject.transform.localPosition&&gameObject.transform.parent.name=="bookbkimage"+rn2.x)
			rnz.transform.localPosition = gameObject.transform.localPosition;
		    //rnz.transform.parent = gameObject.transform;
		if (rnz.transform.localPosition == gameObject.transform.localPosition && gameObject.transform.parent.name == "bookbkimage" + rn2.x) {
			ROOL3.rl3int = gameObject;
			changemove.cmv = gameObject;
			Debug.Log (ROOL3.rl3int.name);
		}
		if (rnz.transform.localPosition == gameObject.transform.localPosition && gameObject.transform.parent.name == "bookbkimage" + rn2.x && lmove!=0) {
			if (Convert.ToInt32 (gameObject.GetComponentInChildren<UnityEngine.UI.Text> ().text) != 5) {
				changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "" + (Convert.ToInt32 (changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text) + 1);
			} else {
				changemove.cmv.GetComponentInChildren<UnityEngine.UI.Text> ().text = "1";
			}
		}
	}

}

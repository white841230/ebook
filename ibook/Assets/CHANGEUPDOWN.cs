using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CHANGEUPDOWN : MonoBehaviour {
	public static int upanddown;
	public GameObject up;
	public GameObject down;
	public GameObject AB7;
	// Use this for initialization
	void Start () {
		AB7 = GameObject.Find ("AB7");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void CHUP()
	{
		down.SetActive (false);
		GameObject.Find ("AB4").GetComponentInChildren<UnityEngine.UI.Text> ().text = ("圖片");
		GameObject.Find ("AB5").GetComponentInChildren<UnityEngine.UI.Text> ().text = ("書名");
		GameObject.Find ("AB6").GetComponentInChildren<UnityEngine.UI.Text> ().text = ("作者");
		AB7.SetActive (true);
		upanddown = 0;
		changemenu.suttef = 0;
		GameObject.Find ("staticvile").GetComponent<changemenu> ().chbookimage ();
	}
	public void CHDW()
	{
		down.SetActive (true);
		GameObject.Find ("AB4").GetComponentInChildren<UnityEngine.UI.Text> ().text = ("底圖");
		GameObject.Find ("AB5").GetComponentInChildren<UnityEngine.UI.Text> ().text = ("圖片");
		GameObject.Find ("AB6").GetComponentInChildren<UnityEngine.UI.Text> ().text = ("文字");
		AB7.SetActive (false);
		upanddown = 1;
		changemenu.suttef = 0;
		GameObject.Find ("staticvile").GetComponent<changemenu> ().chbookname ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeanimation : MonoBehaviour {
	public GameObject ca;
	public static GameObject animting;
	public static int inmoving=0;
	public int y=0;
	public static int annum;
	public int anum;
	public int time=0;
	public int lasttime;
	public int i;
	public int j;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		time = time + 1;
		ca = animting;
		if (inmoving == 0) {
			animting = GameObject.Find ("bookbkimage" + rn2.x);
		}
		y = inmoving;
		anum = annum;
		if (inmoving == 1&&(time-lasttime) > 70) {
			animting.GetComponent<Animator> ().SetTrigger ("all");
			//animting.GetComponentInChildren<Animator> ().SetTrigger ("all");
			foreach(Animator ani in animting.transform.parent.gameObject.GetComponentsInChildren<Animator>()){
				ani.SetTrigger ("all");
			}
			inmoving = 0;
		}
	}
	public void changeanimationn(int n){
		if (inmoving == 0) {
			annum = n;
			animting .GetComponent<changepagean> ().cpa = n;
			inmoving = 1;
			lasttime = time;
			if(n>0)
			{
				animting.GetComponent<Animator> ().SetTrigger (""+n);
				//animting.GetComponentInChildren<Animator> ().SetTrigger (""+n);
				foreach(Animator ani in animting.transform.parent.gameObject.GetComponentsInChildren<Animator>()){
					ani.SetTrigger (""+n);
				}
			}
		}
	}
}

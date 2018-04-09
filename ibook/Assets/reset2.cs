using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset2 : MonoBehaviour {
	public static reset2 ins;
	public static int kabb=0;
	public static int ss=0;
	public int i;
	public int nss;
	// Use this for initialization
	void Start () {
		
	}
	void Awake(){

		if(ins == null){

			ins = this;
			GameObject.DontDestroyOnLoad(gameObject);

		}else if(ins != this){

			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		nss = ss;
		if (kabb == 0) {
			for (i = 2; i < 41; i++) {
				GameObject.Find ("bookbkimage"+i).transform.parent = GameObject.Find ("bookbkimagecanvas").transform;
				rn2.gabb = GameObject.Find ("PAGE1");
				kabb = 1;
			}
		}
	}
}

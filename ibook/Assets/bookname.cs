using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using waqashaxhmi.AndroidNativePlugin;
using System.IO;
using UnityEngine.Sprites;
using System;

public class bookname : MonoBehaviour {
	public static bookname ins;
	public static string bkname;
	public string bname;
	// Use this for initialization
	void Start () {
		//bkname = "小雞吃米圖";
	}
	void Update(){
		bname = bkname;
	}
	void Awake(){
		
		bname = bkname;
		if(ins == null){

			ins = this;
			GameObject.DontDestroyOnLoad(gameObject);

		}else if(ins != this){

			Destroy(gameObject);
		}
	}
}

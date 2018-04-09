using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour {
	
	public static int flonum=0;
	public static int pagenum;
	public static reset ins;
	public static int loadpage = 0;
	public static int first = 0;
	public int pgnn;
	// Use this for initialization
	void Start () {
		flonum = 1;
		pagenum = 1;
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
		pgnn = pagenum;
	}
	public void loadpagg(){
		loadpage = 1;
		first = 0;
	}
}

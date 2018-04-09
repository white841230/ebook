using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changekind : MonoBehaviour {
	public int kindnum;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void change()
	{
		reset.flonum = kindnum;
		imageload.resetx = 1;
	}
}

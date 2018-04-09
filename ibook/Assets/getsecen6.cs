using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getsecen6 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		if (reset.first == 0) {
			GameObject.Find ("rn").transform.localPosition = GameObject.Find ("PAGE1").transform.localPosition;
			GameObject.Find ("bookbkimage1").transform.parent = GameObject.Find ("editcanvas").transform;
			Destroy (gameObject.GetComponent<getsecen6> ());
			reset.first = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

﻿using UnityEngine;
using System.Collections;
public class MarbleCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col) {
		if (col.collider.tag == "Marble")
			print ("Collided with Marble");
	}
}

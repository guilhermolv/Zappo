using UnityEngine;
using System.Collections;
using System;

public class ParticleShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {

		if (Input.GetKey(KeyCode.Space)) {
			GetComponent<ParticleSystem>().emissionRate = 99;
		} else {
			GetComponent<ParticleSystem>().emissionRate = 0;
		}
		
	}
}
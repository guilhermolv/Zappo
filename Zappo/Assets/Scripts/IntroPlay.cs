using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]

public class IntroPlay : MonoBehaviour {

	public MovieTexture intro;

	// Use this for initialization
	void Start () {
		GetComponent<Renderer>().material.mainTexture = intro as MovieTexture;
		GetComponent<AudioSource>().clip = intro.audioClip;
		intro.Play();
		GetComponent<AudioSource>().Play();
	}

	void OnMouseDown(){
		intro.Stop ();
		Application.LoadLevel ("Menu");

	}

}

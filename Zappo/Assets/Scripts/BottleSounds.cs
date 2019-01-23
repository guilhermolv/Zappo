using UnityEngine;
using System.Collections;

public class BottleSounds : MonoBehaviour {
	public AudioClip Bullet;
	public AudioClip Spray;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{				
			audio.PlayOneShot(Bullet, 0.7F);
			print ("shots fired");
		}

		if (Input.GetKey (KeyCode.Space)) {
			audio.PlayOneShot(Spray, 0.7F);
			print ("shots fired");		
		}
	
	}
}

using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {
	
	void OnCollisionEnter (Collision collision)
	{
		Debug.Log ("Col on!");
	}
}

using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float MoveSpeed = 0;
	CharacterController cc;

	// Use this for initialization
	void Start () {

		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	void Move() {
		Vector3 forward = Input.GetAxis ("Vertical") * transform.TransformDirection (Vector3.forward) * MoveSpeed;
		cc.Move (forward * Time.deltaTime);
	}
}

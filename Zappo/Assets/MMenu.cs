using UnityEngine;
using System.Collections;

public class MMenu : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("m"))
			Application.LoadLevel ("Menu");
	
	}
}

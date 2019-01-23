using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public static int health = 100;

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Enemy" || col.gameObject.name == "Enemy 1") {
			health -= 7;
			if (health < 0) {
				print ("game over");
				Application.LoadLevel ("DeathScreen");

				health = 100;
			}
		}
	}

}
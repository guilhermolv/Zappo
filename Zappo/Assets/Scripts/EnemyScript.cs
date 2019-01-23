using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	public static int enemyHealth = 100;
	public AudioClip Dead;
	public AudioClip Walk;
	AudioSource audio;
	bool isDead;

	void Start () {
		audio = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.name == "Bullet(Clone)") {
			enemyHealth -= 10;
			;}
	}

	void OnParticleCollision (GameObject Spray){
		enemyHealth -= 3;


	}
	void Update () {
		if (enemyHealth <= 0) {
			Death ();
		}
	}

	void Death(){		
		isDead = true;
		Destroy (gameObject);
		//enemyHealth = 100;
	}
}

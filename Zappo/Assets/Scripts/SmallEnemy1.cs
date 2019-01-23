using UnityEngine;
using System.Collections;

public class SmallEnemyScript1 : MonoBehaviour {
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
			enemyHealth -= 50;
			print(enemyHealth);
		}
	}
	
	void OnParticleCollision (GameObject Spray){
		enemyHealth -= 30;
		print(enemyHealth);
		
	}
	void Update () {
		if (!isDead && enemyHealth <= 0) {
			Destroy (gameObject);
			Death ();
		}
	}
	
	void Death(){		
		isDead = true;
		Destroy (gameObject);
		//enemyHealth = 100;
	}
}

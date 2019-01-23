using UnityEngine;
using System.Collections;

public class EnemyScript1 : MonoBehaviour {
	public static int enemyHealth1 = 100;
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
			enemyHealth1 -= 10;
			print(enemyHealth1);
		}
	}
	
	void OnParticleCollision (GameObject Spray){
		enemyHealth1 -= 3;
		print(enemyHealth1);
		
	}
	void Update () {
		if (enemyHealth1 <= 0) {
			Death ();
		}
	}
	
	void Death(){		
		isDead = true;
		print ("isDead " + isDead);
		Destroy (gameObject);
		//enemyHealth = 100;
	}
}

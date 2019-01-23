using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject Bullet;
	public Transform BulletSpawn;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{

			GameObject clone;
			clone = Instantiate(Bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation) as GameObject;
			Destroy(clone, 3);

		}
	
	}
}

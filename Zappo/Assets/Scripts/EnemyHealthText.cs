using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealthText : MonoBehaviour {
	
	Text healthText;
	
	void Start() {
		healthText = GetComponent<Text>();
	}
	
	void Update() {
		healthText.text = (EnemyScript.enemyHealth.ToString());
	}
	
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealthText1 : MonoBehaviour {
	
	Text healthText;
	
	void Start() {
		healthText = GetComponent<Text>();
	}
	
	void Update() {
		healthText.text = (EnemyScript1.enemyHealth1.ToString());
	}
	
}

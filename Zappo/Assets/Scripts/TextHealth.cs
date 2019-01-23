using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextHealth : MonoBehaviour {

	Text healthText;

	void Start() {
		healthText = GetComponent<Text>();
	}

	void Update() {
		healthText.text = (PlayerHealth.health.ToString());
	}

}

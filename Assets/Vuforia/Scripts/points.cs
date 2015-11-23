using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {
	Text instruction;
	private int currentScore = 0;

	void Start() {
		instruction = GetComponent<Text>();
	}
}
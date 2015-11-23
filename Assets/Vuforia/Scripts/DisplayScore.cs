using UnityEngine;
using UnityEngine.UI;

public class DisplayGameScore : MonoBehaviour {
	public static Text instruction;
	public static int currentScore = 0;

	void Start() {
		instruction = GetComponent<Text>();
		instruction.text = "" + currentScore;
	}

	void Update () {
         instruction.text= "" + currentScore;
     }
}
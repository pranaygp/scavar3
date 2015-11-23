using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject {
	public class ScoreManager : MonoBehaviour {
		public static Text instruction;
		public static int currentScore = 0;

		void Awake() {
			GameObject canvas = GameObject.Find("HUDCanvas");
			Text[] textValue = canvas.GetComponentsInChildren<Text>();
			instruction = textValue[0];
			instruction.text = "Points: " + currentScore;
			/*instruction = GetComponent<Text>();
			instruction.text = "Score: " + currentScore;
			*/
		}

		void Update () {
			instruction.text = "Points: " + currentScore;
	        //instruction.text= "Points: " + currentScore;
	 	}
	}
}
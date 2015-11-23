using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject {
	public class endCheck : MonoBehaviour {
		GameObject HUDCanvas;
		GameObject HUD2;
		void Start() {
			//Do nothing
			HUDCanvas = GameObject.Find("HUDCanvas");
			HUD2 = GameObject.Find("HUD2");
			HUD2.SetActive(false);
		}

		void Update() {
			int flagsLeft = -1;
			int.TryParse(Server.GET("flags/all/flagsleft", ""), out flagsLeft);

			if (flagsLeft == 0) {
				//Transition to endgame
				HUDCanvas.SetActive(false);
				HUD2.SetActive(true);
				Text[] textValue = HUD2.GetComponentsInChildren<Text>();
				/*textValue[0].text = "Points Scored: " 
					+ CompleteProject.ScoreManager.currentScore + "!";*/
				textValue[1].text = "Points Scored: " 
					+ CompleteProject.ScoreManager.currentScore + "!";
			}
		}
	}
}
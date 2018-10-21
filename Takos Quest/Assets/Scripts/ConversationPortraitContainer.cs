using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationPortraitContainer : MonoBehaviour {

	public ConversationPortraitControl[] allPosiblePortraits;
	public int currentGirlSelected = -1;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void ChangePortrait(int numbOfGirl, int numbOfPos, int numbOfAnimation){
		if (currentGirlSelected != numbOfGirl) {
			allPosiblePortraits [currentGirlSelected].DisappearPortrait ();
		}
		currentGirlSelected = numbOfGirl;
		allPosiblePortraits [numbOfGirl].AppearPortrait (numbOfPos, numbOfAnimation);
	}
}


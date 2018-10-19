using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllLanguageContainer : MonoBehaviour {

	public int currentLanguage;
	public ApplicateLanguageValue[] allLanguageTexts;
	// Use this for initialization
	void Start () {
		currentLanguage = PlayerPrefs.GetInt ("CurrentLanguage");
		ApplicateAllLanguageChange (currentLanguage);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ApplicateAllLanguageChange(int language){
		currentLanguage = language;
		for (int i = 0; i < allLanguageTexts.Length; i++) {
			allLanguageTexts [i].ApplicateChangeLanguage (language);
		}
	}
}

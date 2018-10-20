using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLanguageSettings : MonoBehaviour {

	public AllLanguageContainer allLanguageContainer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void ChangeLanguage(int language){
		PlayerPrefs.SetInt ("CurrentLanguage", language);
		allLanguageContainer.ApplicateAllLanguageChange (language);
	}
}

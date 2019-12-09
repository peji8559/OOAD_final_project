using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class save_names : MonoBehaviour
{
    public InputField inputText;
    string username;
    string tutorialText;
    void Start(){
    	tutorialText=PlayerPrefs.GetString("tutorialTextKeyName");
    	inputText.text=tutorialText;
    }

    public void SaveThis(){
    	tutorialText=inputText.text;
    	PlayerPrefs.SetString("tutorialTextKeyName", tutorialText);
    }
}

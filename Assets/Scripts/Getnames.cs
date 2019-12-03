using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Getnames : MonoBehaviour
{
    public Text inputText;
    string tutorialText;
    void Start(){
    	tutorialText=PlayerPrefs.GetString("tutorialTextKeyName");
    	inputText.text=tutorialText;
    }

}

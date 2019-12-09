using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ScoreboardScript : MonoBehaviour
{
    public Text currentScore;
    void Start(){
    	currentScore.text =PlayerPrefs.GetString("CurrentScore");
    }
    public void LoadMenu(){
    	SceneManager.LoadScene(0);
    }
    public void QuitGame(){
    	Application.Quit();
    }
}

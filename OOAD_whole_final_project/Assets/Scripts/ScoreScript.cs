using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreUI;

    public int score;

    void Start()
    {   score=0;
        scoreUI.text = score.ToString();
        InvokeRepeating("increaseScore", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
        scoreUI.text = score.ToString(); 
    }

    public void increaseScore()
    {
        this.score += 1;
        PlayerPrefs.SetString("CurrentScore", score.ToString());
        

    }

    public void increaseScoreForCannibal()
    {
        this.score += 5;
    }

    public int getScore() {
        return this.score;
    }
}

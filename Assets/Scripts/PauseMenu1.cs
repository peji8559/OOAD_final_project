using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu1 : MonoBehaviour
{
    public static bool GameIsPaused=false;
    public GameObject pauseMenuUI;
    public GameObject crossUI;

    // Update is called once per frame
    void Start(){
    	Time.timeScale = 1f;
    	Cursor.lockState = CursorLockMode.Locked;
    	Cursor.visible = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
        	if(GameIsPaused){
        		Resume();
        	}else{
        		Pause();
        	}
        }
        if(Input.GetKeyDown(KeyCode.P)){
        	if(GameIsPaused){
        		Resume();
        	}else{

        		Pause();
        	}
        }
        if(GameIsPaused){
        	Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        } else{
        	Cursor.lockState = CursorLockMode.Locked;
    	Cursor.visible = false;
        }
    }
    public void Resume(){
    	pauseMenuUI.SetActive(false);
    	crossUI.SetActive(true);
    	Time.timeScale = 1f;
    	GameIsPaused=false;
    }
    void Pause(){
    	crossUI.SetActive(false);
    	pauseMenuUI.SetActive(true);
    	Time.timeScale = 0f;
    	GameIsPaused=true;
    }
    public void LoadMenu(){
    	SceneManager.LoadScene(0);
    }
    public void QuitGame(){
    	Application.Quit();
    }
}

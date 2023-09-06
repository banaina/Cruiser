using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync("LevelsScreen");
    }
    public void CustomizeCharacter(){
        SceneManager.LoadSceneAsync("CustomizeScreen");
    }
    public void ModifyOptions(){
        SceneManager.LoadSceneAsync("OptionsScreen");
    }
    public void GoBack(){
        SceneManager.LoadSceneAsync("StartScreen");
    }
    public void LevelOne(){
        SceneManager.LoadSceneAsync("LevelOne");
    }
    public void LevelTwo(){
        SceneManager.LoadSceneAsync("LevelTwo");
    }
    public void LevelThree(){
        SceneManager.LoadSceneAsync("LevelThree");
    }
}   

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void ButtonStart(){
        SceneManager.LoadScene(1);
    }
    public void ButtonStartLevel1(){
        SceneManager.LoadScene(1);
    }
    public void ButtonStartLevel2(){
        SceneManager.LoadScene(2);
    }
    public void ButtonQuit(){
        Application.Quit();
    }
}

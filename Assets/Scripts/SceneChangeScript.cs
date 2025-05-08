using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChangeScript : MonoBehaviour
{
    public void ToUIScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }



}

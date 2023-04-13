using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void FirstLevel()
    {
        SceneManager.LoadScene("Level1");
    }

    public void SecondLevel() 
    {
        SceneManager.LoadScene("Level2");
    }

    public void ThirdLevel()
    {
        SceneManager.LoadScene("Level2");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public AudioSource buttonclick;
    void Start()
    {
        buttonclick= GetComponent<AudioSource>();
    }
    void Update()
    {

    }

    public void NextLevel()
    {
        buttonclick.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        buttonclick.Play();
        Application.Quit();
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}

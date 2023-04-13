using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject Canvas;
    public void Start()
    {
        Canvas.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {

            if (Time.timeScale == 1)    
            {
                Time.timeScale = 0;
                Canvas.gameObject.SetActive(true);

            }
            else
            {
                Time.timeScale = 1;
                Canvas.gameObject.SetActive(false);
            }

        }
            
    }
}

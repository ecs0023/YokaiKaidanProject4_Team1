using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactables : MonoBehaviour
{
    public GameObject Canvas;

    public void Start()
    {
        Canvas.gameObject.SetActive(false);
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Canvas.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Destroy(gameObject);
            }

        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Canvas.gameObject.SetActive(false);
        }
    }
}

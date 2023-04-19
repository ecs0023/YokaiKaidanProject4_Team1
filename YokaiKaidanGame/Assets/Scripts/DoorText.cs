using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorText : MonoBehaviour
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoundDoorNEW : MonoBehaviour
{
    public GameObject Canvas;


    public void Start()
    {
        Canvas.gameObject.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
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

    public void OpenDoor()
    {
        Destroy(gameObject, 0.5f);
    }
}

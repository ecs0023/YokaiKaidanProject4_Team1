using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hasHoundKey;
    public bool hasStagKey;
    public bool hasBearKey;
    public bool flashlighton;
    public int health = 6;
    public Vector2 mouse;
    public int speed = 4;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        mouse.x = Input.GetAxis("Mouse X");
        mouse.y = Input.GetAxis("Mouse Y");
    }


    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "HoundKey")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasHoundKey = true;
                Destroy(other.gameObject);
                Debug.Log("You've found the Hound Key.");
            }
        }

        if (other.gameObject.name == "HoundDoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hasHoundKey == true)
                {

                    Destroy(other.gameObject);
                    Debug.Log("HoundKey Activated");
                }
                else
                {
                    Debug.Log("You need the Hound Key to open this door");
                }
            }
        }

        if (other.gameObject.name == "BearKey")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasBearKey = true;
                Destroy(other.gameObject);
                Debug.Log("You've found the Bear Key.");
            }
        }

        if (other.gameObject.name == "BearDoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (hasBearKey == true)
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    Debug.Log("You need the Bear Key to open this door");
                }
            }
        }

        if (other.gameObject.name == "StagKey")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasStagKey = true;
                Destroy(other.gameObject);
                Debug.Log("You've found the Stag Key.");
            }
        }

        if (other.gameObject.name == "StagDoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hasStagKey == true)
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    Debug.Log("You need the Stag Key to open this door");
                }
            }
        }
    }
}

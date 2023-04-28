using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lanternonoff : MonoBehaviour
{
    public static bool lanternisoff = false;
    public static bool lanternCollider = true;
    //private float timer;
    //private float cooldown = 0.5f;
    public int damage;

    public GameObject lantern;

    

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            if (lanternisoff == false)
            {
                lanternCollider = true;
               
            }
        }
    }

    void Start()
    {
        lantern.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (lanternisoff)
            {
                ON();
            }
            else
            {
                OFF();
            }
        }

    }

    void ON()
    {
        lantern.SetActive(true);
        lanternisoff = false;
        lanternCollider = true;


    }

    void OFF()
    {
        lantern.SetActive(false);
        lanternisoff = true;
        lanternCollider = false;
    }
}
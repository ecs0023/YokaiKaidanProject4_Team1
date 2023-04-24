using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanternonoff : MonoBehaviour
{
    public static bool lanternisoff = false;

    public GameObject lantern;

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
    }

    void OFF()
    {
        lantern.SetActive(false);
        lanternisoff = true;
    }
}
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lanternonoff : MonoBehaviour
{
    public static bool lanternisoff = false;
    public static bool lanternCollider = true;
    public int damage;
    public Animator anim;

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
        anim = this.GetComponent<Animator>();
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
        anim.SetTrigger("Equip");
        lantern.SetActive(true);
        lanternisoff = false;
        lanternCollider = true;


    }

    void OFF()
    {
        anim.SetTrigger("Unequip");
        lantern.SetActive(false);
        lanternisoff = true;
        lanternCollider = false;
    }
}
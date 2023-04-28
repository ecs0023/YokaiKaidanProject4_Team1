using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTANIM : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim= GetComponent<Animator>();
    }

    
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A ) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

    }
}

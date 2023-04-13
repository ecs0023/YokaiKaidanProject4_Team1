using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E1AnimationController : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim=GetComponent<Animator>();  
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Player")
        {
            anim.SetBool("isRunning", true);
        }
            
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            anim.SetBool("isRunning", false);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EnemyAnimCont : MonoBehaviour
{
    public Animator anim;
    //public AudioSource enemysound;
    private void Start()
    {

        anim = this.GetComponent<Animator>();
        //enemysound = this.GetComponent<AudioSource>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("isChasing", true);
            //enemysound.Play();
            Debug.Log("Player In Range");
 
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("isChasing", false);
            //enemysound.Stop();
            Debug.Log("Player left Range");
        }
    }
}

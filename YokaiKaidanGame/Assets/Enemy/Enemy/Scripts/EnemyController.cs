using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
public class EnemyController : MonoBehaviour
{

    //This gets all needed game parts
    public float adjust;
    public float moveSpeed =2f;
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movement;
    public Animator anim;
    public AudioSource enemysound;
    public int PlayerHealth = 3;
    public GameObject Canvas;
    public SpriteRenderer PlayerRend;

    void Start()
    {
        Canvas.gameObject.SetActive(false);
        rb =this.GetComponent<Rigidbody2D>();
        anim=this.GetComponent<Animator>();
        enemysound=this.GetComponent<AudioSource>();
        PlayerRend=gameObject.GetComponent<SpriteRenderer>();
        
    }
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle= Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        rb.rotation = angle-adjust;
        direction.Normalize();
        movement = direction;
    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("isChasing", true);
            enemysound.Play();
            Debug.Log("Player in Range");
            if (PlayerHealth > 0)
            {
                PlayerHealth--;
            }
            if(PlayerHealth<=0)
            {
                Canvas.gameObject.SetActive(true);
            }
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("isChasing", false);
            enemysound.Stop();
            Debug.Log("Player left Range");
        }
    }

}

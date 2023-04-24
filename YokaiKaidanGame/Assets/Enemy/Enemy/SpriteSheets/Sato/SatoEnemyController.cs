using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatoEnemyController : MonoBehaviour
{
    //This gets all needed game parts
    public float adjust;
    public float moveSpeed = 0f;
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movement;
    public Animator anim;
    public AudioSource enemysound;
    public BoxCollider2D range;
    

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
        enemysound = this.GetComponent<AudioSource>();
        range= GetComponentInChildren<BoxCollider2D>();
    }
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle - adjust;
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
            moveSpeed = 2f;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            anim.SetBool("isChasing", false);
            enemysound.Stop();
            moveSpeed = 0f;
        }
    }
    
}

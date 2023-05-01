using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{

    #region
    public int enemyHealth;
    public float adjust;
    public float moveSpeed = 6f;
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movement;
    public AudioSource enemysound;
    private float distance;
    public float range;
    public Animator anim;
    public GameHealth script;


    public SpriteRenderer sr;
    #endregion
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        enemysound = this.GetComponent<AudioSource>();
        anim = this.GetComponent<Animator>();
        script.GetComponent<GameHealth>();
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.white;
    }




    #region
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle - adjust;
        direction.Normalize();
        movement = direction;

        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        if (distance < range)
        {
            moveCharacter(movement);
            anim.SetBool("isChasing", true);
        }
        else
        {
            anim.SetBool("isChasing", false);
        }

    }


    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    #endregion
    //EndMovement
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            script.DealDamageToPlayer();
            anim.SetTrigger("isAttacking");
            sr.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.ResetTrigger("isAttacking");
        sr.color = Color.white;
        moveSpeed = 4;
        anim.SetBool("ischasing", true);
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "hitbox")
        {
            moveSpeed= 0;
            anim.SetBool("isChasing", false);
        }
    }

}


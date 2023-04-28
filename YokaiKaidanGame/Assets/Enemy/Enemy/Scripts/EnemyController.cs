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

    //This gets all needed game parts
    #region
    public int enemyhealth;
    public float adjust;
    public float moveSpeed = 2f;
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movement;
    public AudioSource enemysound;
    private float distance;
    public float range;
    public Animator anim;
    public PlayerHealth playerscript;
    public int damage;
    private float timer;
    private float cooldown = 0.5f;
    private float deathcooldown = 1.5f;
    public SpriteRenderer sr;
    #endregion
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        enemysound = this.GetComponent<AudioSource>();
        anim = this.GetComponent<Animator>();
        playerscript.GetComponent<PlayerTestController>();
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

        if (enemyhealth<=0)
        {
            anim.SetTrigger("death");
            EnemyDestruction();


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
            DealDamageToPlayer();
            anim.SetTrigger("isAttacking");
            sr.color = Color.red;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "hitbox")
        {

            DealDamage();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.ResetTrigger("isAttacking");
        sr.color = Color.white;
    }

    private void DealDamageToPlayer()
    {
        
        playerscript.health -= damage;
        

    }
    IEnumerator EnemyDestruction()
    {

        yield return new WaitForSeconds(1/2);
        Destroy(gameObject);

    }
    IEnumerator DealDamage()
    {
        yield return new WaitForSeconds(1/2);
        enemyhealth--;
        
    }
}


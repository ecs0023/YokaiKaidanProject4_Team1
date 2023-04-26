using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class EnemyController : MonoBehaviour
{

    //This gets all needed game parts
    #region
    public int health=2;
    public float adjust;
    public float moveSpeed =2f;
    public Transform player;
    public Rigidbody2D rb;
    private Vector2 movement;
    public AudioSource enemysound;
    private float distance;
    public float range;
    public Animator anim;
    public PlayerHealth playerscript;
    public int damage;
    #endregion
    void Start()
    {
        rb =this.GetComponent<Rigidbody2D>();
        enemysound = this.GetComponent<AudioSource>();  
        anim= this.GetComponent<Animator>();
        playerscript.GetComponent<PlayerHealth>();
    }
    //EnemyMovement
    #region
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector3 direction = player.position - transform.position;
        float angle= Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        rb.rotation = angle-adjust;
        direction.Normalize();
        movement = direction;

        if (Input.GetKeyDown(KeyCode.R))
        {
            DealDamageToPlayer();
        }
    }
    private void FixedUpdate()
    {
        if (distance < range)
        {
            moveCharacter(movement);
        }
        else
        {
        }
        
    }


    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    #endregion
    //EndMovement
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("In range");
            DealDamageToPlayer();
            anim.SetBool("isAttacking", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        anim.SetBool("isAttacking", false);
    }
    private void DealDamageToPlayer()
    {
        playerscript.health -= 2;
    }

}
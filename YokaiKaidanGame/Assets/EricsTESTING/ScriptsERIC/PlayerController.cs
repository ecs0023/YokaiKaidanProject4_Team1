using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public bool hasHoundKey;
    public bool hasStagKey;
    public bool hasBearKey;
    public bool flashlighton;
    private Vector2 moveDirection;
    public int playerhealth;
    public Animator anim;
    public SpriteRenderer spriteRend;
    public int health = 6;



    private void Start()
    {
        hasHoundKey = false;
        hasBearKey = false;
        hasStagKey = false;
        anim = this.GetComponent<Animator>();
        flashlighton = false;
        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.color = Color.white;
    }
    private void Update()
    {
        ProcessInputs();

    }

    public void FixedUpdate()
    {
        Move();
    }

    public void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY);
        if (moveY>0)
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }

    }

    public void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "HoundKey")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasHoundKey = true;
                Destroy(other.gameObject);
                Debug.Log("You've found the Hound Key.");
            }
        }

        if (other.gameObject.name == "HoundDoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hasHoundKey == true)
                {

                    Destroy(other.gameObject);
                    Debug.Log("HoundKey Activated");
                }
                else
                {
                    Debug.Log("You need the Hound Key to open this door");
                }
            }
        }

        if (other.gameObject.name == "BearKey")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasBearKey = true;
                Destroy(other.gameObject);
                Debug.Log("You've found the Bear Key.");
            }
        }

        if (other.gameObject.name == "BearDoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                if (hasBearKey == true)
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    Debug.Log("You need the Bear Key to open this door");
                }
            }
        }

        if (other.gameObject.name == "StagKey")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hasStagKey = true;
                Destroy(other.gameObject);
                Debug.Log("You've found the Stag Key.");
            }
        }

        if (other.gameObject.name == "StagDoor")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hasStagKey == true)
                {
                    Destroy(other.gameObject);
                }
                else
                {
                    Debug.Log("You need the Stag Key to open this door");
                }
            }
        }
    }
}

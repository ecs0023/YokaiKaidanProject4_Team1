using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerTestController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public bool hasHoundKey;
    public bool hasStagKey;
    public bool hasBearKey;
    private Vector2 moveDirection;

    public void Start()
    {
        hasHoundKey = false;
        hasBearKey = false;
        hasStagKey = false;
    }
    public void Update()
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
    }
    public void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "HoundKey")
        {
            hasHoundKey = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "HoundDoor")
        {
            if (hasHoundKey == true)
            {
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("You need a key to open this door");
            }
        }

        if (other.gameObject.name == "BearKey")
        {
            hasBearKey = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "BearDoor")
        {
            if (hasBearKey == true)
            {
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("You need a key to open this door");
            }
        }

        if (other.gameObject.name == "StagKey")
        {
            hasStagKey = true;
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "StagDoor")
        {
            if (hasStagKey == true)
            {
                Destroy(other.gameObject);
            }
            else
            {
                Debug.Log("You need a key to open this door");
            }
        }
    }
}

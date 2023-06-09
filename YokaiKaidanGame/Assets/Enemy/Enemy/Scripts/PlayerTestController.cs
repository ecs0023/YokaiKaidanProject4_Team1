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
    public bool flashlighton;
    private Vector2 moveDirection;
    public int playerhealth;
    public Animator anim;
    private float timer;
    public SpriteRenderer spriteRend;
    public GameHealth script;
    public int l = -1;
    //Erics stuff
    public GameObject Lanturn;
    public BoxCollider2D lanturnlight;

    public void Start()
    {
        script=GetComponent<GameHealth>();
        hasHoundKey = false;
        hasBearKey = false;
        hasStagKey = false;
        anim = this.GetComponent<Animator>();
        flashlighton = false;
        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.color = Color.white;
        Lanturn.gameObject.SetActive(false);
        lanturnlight=GetComponentInChildren<BoxCollider2D>();
        
    }
    public void Update()
    {

        //PlayerMovement
        ProcessInputs();

        //Equip and Unequip Light
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            l = l * -1;
            if(l==1)
            {
                Lanturn.SetActive(true);
            }
            if(l==-1)
            {
                Lanturn.SetActive(false);
            }

        }
        
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

    void OnTriggerStay2D(Collider2D other)
    {

        //Doors and Keys
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
        //end of Doors and Keys

    }

    

}

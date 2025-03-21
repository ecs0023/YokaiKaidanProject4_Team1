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
        if(Mathf.Abs(moveX)>0 || Mathf.Abs(moveY) > 0)
        {
            anim.SetBool("isWalking",true);
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

    void OnTriggerEnter2D(Collider2D other)
    {

        //Doors and Keys
        if (other.gameObject.name == "HoundDoor")
        {
                if (hasHoundKey == true)
                {
                    Destroy(other.gameObject, 0.2f);
                }
        }
        if (other.gameObject.name == "BearDoor")
        {
                if (hasBearKey == true)
                {
                Destroy(other.gameObject, 0.2f);
            }
        }
        if (other.gameObject.name == "StagDoor")
        {
                if (hasStagKey == true)
                {
                Destroy(other.gameObject, 0.2f);
            }
        }
        //end of Doors and Keys

    }
    public void HasHound()
    {
        hasHoundKey = true;
    }
    public void HasBear()
    {
        hasBearKey = true;
    }
    public void HasStag()
    {
        hasStagKey = true;
    }



}

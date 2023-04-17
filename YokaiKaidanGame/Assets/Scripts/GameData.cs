using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public int playerHealth=2;
    public int enemyHealth=2;
    public BoxCollider2D playerBoxCollider;
    public BoxCollider2D enemyBoxCollider;
    public int keycount= 3;

    void Start()
    {
        playerBoxCollider= GetComponent<BoxCollider2D>();
        enemyBoxCollider= GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        
    }
}

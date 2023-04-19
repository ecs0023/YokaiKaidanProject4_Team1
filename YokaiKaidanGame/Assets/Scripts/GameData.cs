using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public int PlayerHealth = 2;
    public int SatoHealth=5;
    public int OtsuyaHealth = 2;
    public int OiwaHealth = 2;
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

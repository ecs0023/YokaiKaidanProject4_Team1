using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHealth : MonoBehaviour
{
    public float PlayerHealth=6;
    public float OtsuyaHealth=8;
    public float OiwaHealth=8;
    public float SatoHealth=16;
    public GameObject Player;
    public GameObject Oiwa;
    public GameObject Sato;
    public GameObject Otsuya;


    public void Start()
    {
        Player = GameObject.Find("Player");
        Oiwa = GameObject.Find("Oiwa");
        Otsuya = GameObject.Find("Otsuya");
        Sato = GameObject.Find("Sato");


    }

    public void Update()
    {
        if(PlayerHealth <= 0)
        {
            Debug.Log("PlayerDied");
            SceneManager.LoadScene("YouLose");
        }
        if (OtsuyaHealth <= 0)
        {
            Destroy(Otsuya);
        }
        if(OiwaHealth<=0)
        {
            Destroy(Oiwa);
        }
        if(SatoHealth<=0)
        {
            Destroy(Sato);
            SceneManager.LoadScene("YouWin");

        }
    }
    public void DealDamageToOtsuya()
    {
        OtsuyaHealth--;
    }
    public void DealDamageToOiwa()
    {
        OiwaHealth--;
    }
    public void DealDamageToSato()
    {
        OtsuyaHealth--;
    }
    public void DealDamageToPlayer()
    {
        PlayerHealth--;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHealth : MonoBehaviour
{
    public int PlayerHealth=6;
    public int OtsuyaHealth=8;
    public int OiwaHealth=8;
    public int SatoHealth=16;
    public GameObject Player;



    public void Start()
    {
        Player = GameObject.Find("Player");



    }

    public void Update()
    {
        if(PlayerHealth <= 0)
        {
            Debug.Log("PlayerDied");
            SceneManager.LoadScene("YouLose");
        }

    }
    public IEnumerator DealDamageToOtsuya()
    {
        yield return new WaitForSeconds(0.5f);
        OtsuyaHealth--;
    }
    public IEnumerator DealDamageToOiwa()
    {
        yield return new WaitForSeconds(0.5f);
        OiwaHealth--;
    }
    public IEnumerator DealDamageToSato()
    {
        yield return new WaitForSeconds(0.5f);
        OtsuyaHealth--;
    }
    public void DealDamageToPlayer()
    {
       
        PlayerHealth--;
    }

}

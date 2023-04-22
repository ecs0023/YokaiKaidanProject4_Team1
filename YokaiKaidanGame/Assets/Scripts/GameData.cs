using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            enemyAtm.DealDamage(playerAtm.gameObject);
        }
    }
}


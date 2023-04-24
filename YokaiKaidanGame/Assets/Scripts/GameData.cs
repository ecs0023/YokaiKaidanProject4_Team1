using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager OtsuyaAtm;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            playerAtm.DealDamage(OtsuyaAtm.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            OtsuyaAtm.DealDamage(playerAtm.gameObject);
        }
    }
}


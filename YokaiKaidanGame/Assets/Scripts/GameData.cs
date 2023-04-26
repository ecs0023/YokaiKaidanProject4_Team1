using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager OtsuyaAtm;
    public AttributesManager SatoAtm;
    public AttributesManager OiwaAtm;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerAtm.DealDamage(OtsuyaAtm.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            OtsuyaAtm.DealDamage(playerAtm.gameObject);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagKeyPickup : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerTestController script1 = player.GetComponent<PlayerTestController>();
            script1.HasStag();
            Destroy(gameObject);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoundKeyPickup : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            PlayerTestController script1 = player.GetComponent<PlayerTestController>();
            script1.HasHound();
            Destroy(gameObject);
        }
    }
}

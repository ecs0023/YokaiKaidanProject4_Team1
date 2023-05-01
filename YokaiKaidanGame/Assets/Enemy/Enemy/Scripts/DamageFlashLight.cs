using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageFlashLight : MonoBehaviour
{
    public GameHealth script;
    
    void Start()
    {
        script = GetComponent<GameHealth>();
    }

    
    void Update()
    {
        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Otsuya")
        {
            script.DealDamageToOtsuya();
        }
        if (collision.tag == "Oiwa")
        {
            script.DealDamageToOiwa();
        }
        if (collision.tag == "Sato")
        {
            script.DealDamageToSato();
        }
    }
}

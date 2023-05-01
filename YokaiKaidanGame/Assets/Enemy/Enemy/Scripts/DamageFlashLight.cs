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
    private void OnTriggerStay2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Otsuya")
        {
            script.OtsuyaHealth--;
        }
        if (enemy.gameObject.tag == "Oiwa")
        {
            script.OiwaHealth--;
        }
        if (enemy.gameObject.tag == "Sato")
        {
            script.SatoHealth--;
        }
    }

}

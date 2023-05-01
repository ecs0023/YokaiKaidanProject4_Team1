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
}

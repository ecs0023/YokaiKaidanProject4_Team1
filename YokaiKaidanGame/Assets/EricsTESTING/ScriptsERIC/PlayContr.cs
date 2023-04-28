using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayContr : MonoBehaviour
{
    
    void Start()
    {

    }
    #region
    public float speed = 50;
    public Transform player;

    public void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * speed * Time.deltaTime;

        player.transform.position += tempVect;

    }
    #endregion

}

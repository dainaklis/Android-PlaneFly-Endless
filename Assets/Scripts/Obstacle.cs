using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if (collider.tag == "Player")
        {
            
            SoundManager.PlaySound("sfx14");

            Destroy(player.gameObject);
        }
            
        
    }
}

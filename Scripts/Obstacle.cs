using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    //[SerializeField] GameObject explose;
    

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

        else if (collider.tag == "Player") // GALIMA IR TAIP = (collider.gameObject.tag == "Player")
        {
            
            SoundManager.PlaySound("sfx14");
            //Instantiate(explose, transform.position, Quaternion.identity);

            //Destroy(player.gameObject);
            Destroy(collider.gameObject);
            //Destroy(gameObject); //SUnaikina METEORUS jei atsitrenki
        }
            
        
    }
}

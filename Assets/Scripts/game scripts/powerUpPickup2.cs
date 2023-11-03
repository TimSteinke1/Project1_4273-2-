 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpPickup2 : MonoBehaviour

{
    public float healthBoost = 2f; 
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D other){
        if (other.CompareTag("Player"))
        {
            pickup(other);
        }
    }

    void pickup (Collider2D player){

        playerStats stats = player.GetComponent<playerStats>();
        stats.health += healthBoost;
        
        Destroy(gameObject);
    }

}


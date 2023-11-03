using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPickup1 : MonoBehaviour
{
    public float speedBoost = 2f; 
    // Start is called before the first frame update
    void OnTriggerEnter2D (Collider2D other){
        if (other.CompareTag("Player") || other.CompareTag("Bullet"))
        {
            pickup(other);
        }
    }

    void pickup (Collider2D player){

        playerMovements stats = player.GetComponent<playerMovements>();
        stats.speed += speedBoost;
        
        Destroy(gameObject);
    }
}

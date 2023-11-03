using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public float damage = 1f;
    public float health = 1f;

    void Update() {
        if (health <= 0) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Debug.Log(hitInfo.name);
        if (hitInfo.name == "Bullet(Clone)") {
            health -= 1;
            Debug.Log("ENEMY HIT");
        }
        if (hitInfo.name == "Player" || hitInfo.name == "playerBound") {
            Destroy(gameObject);
            Debug.Log("PLAYER HIT");
        }
    }
}

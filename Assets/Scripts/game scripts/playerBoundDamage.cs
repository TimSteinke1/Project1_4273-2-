using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBoundDamage : MonoBehaviour
{
    public GameObject playerObject;
    public GameObject enemy1, enemy2, enemy3;
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.name == "Enemy1(Clone)") {
            playerObject.GetComponent<playerStats>().health -= enemy1.GetComponent<enemyStats>().damage;
        }
        if (hitInfo.name == "Enemy2(Clone)") {
            playerObject.GetComponent<playerStats>().health -= enemy2.GetComponent<enemyStats>().damage;
        }
        if (hitInfo.name == "BossEnemy(Clone)") {
            playerObject.GetComponent<playerStats>().health -= enemy3.GetComponent<enemyStats>().damage;
        }
    }
}

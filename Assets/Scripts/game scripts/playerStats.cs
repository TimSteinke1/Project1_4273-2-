using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerStats : MonoBehaviour
{
    public float health = 10;
    public GameObject enemy1, enemy2, enemy3;

    void Update() {
        if (health <= 0) {
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo) {
        Debug.Log(hitInfo.name);
        if (hitInfo.name == "Enemy1(Clone)") {
            health -= enemy1.GetComponent<enemyStats>().damage;
        }
        if (hitInfo.name == "Enemy2(Clone)") {
            health -= enemy2.GetComponent<enemyStats>().damage;
        }
        if (hitInfo.name == "BossEnemy(Clone)") {
            health -= enemy3.GetComponent<enemyStats>().damage;
        }
    }
}

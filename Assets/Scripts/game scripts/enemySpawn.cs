using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class enemySpawn : MonoBehaviour
{
    public Transform SpawnPoint1, SpawnPoint2, SpawnPoint3, SpawnPoint4, SpawnPoint5;
    public GameObject enemy1Prefab, enemy2Prefab, enemy3Prefab, powerUp1Prefab, powerUp2Prefab;
    private GameObject spawnedEnemy;
    public float spawnMultiplier;

    void OnEnable()
    {
        spawnMultiplier = PlayerPrefs.GetInt("spawnX");
    }

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, spawnMultiplier);        // spawns an enemy every 5 seconds
    }

    void SpawnEnemy()
    {
        System.Random rnd = new System.Random();
        int spawnPoint = rnd.Next(1, 6);
        int enemyChoice = rnd.Next(1, 12);
        int powerUp = rnd.Next(1,3);

        /* Enemy randomizer, weighted toward choosing lower-class enemies */
        if (enemyChoice > 0 && enemyChoice <= 6) {
            spawnedEnemy = enemy1Prefab;
        } else {
            if (enemyChoice > 6 && enemyChoice <= 9) {
                spawnedEnemy = enemy2Prefab;
            } else {
                if (enemyChoice == 10) {
                    spawnedEnemy = enemy3Prefab;
                } else {
                    if(powerUp == 1) {
                    spawnedEnemy = powerUp1Prefab;
                } else {
                    spawnedEnemy = powerUp2Prefab;
                    }
                }
            }
        }

        switch (spawnPoint) {
            case 1: 
                Instantiate(spawnedEnemy, SpawnPoint1.position, SpawnPoint1.rotation);
                break;
            case 2:
                Instantiate(spawnedEnemy, SpawnPoint2.position, SpawnPoint2.rotation);
                break;
            case 3:
                Instantiate(spawnedEnemy, SpawnPoint3.position, SpawnPoint3.rotation);
                break;
            case 4:
                Instantiate(spawnedEnemy, SpawnPoint4.position, SpawnPoint4.rotation);
                break;
            case 5:
                Instantiate(spawnedEnemy, SpawnPoint5.position, SpawnPoint5.rotation);
                break;
            default:
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class healthTracker : MonoBehaviour
{
    public TMP_Text tex;
    public GameObject healthyPlayer;
    public float playerHealth;

    void Update() {
        playerHealth = healthyPlayer.GetComponent<playerStats>().health;
        tex.text = playerHealth.ToString();
    }
}

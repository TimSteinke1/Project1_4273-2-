using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyMenu : MonoBehaviour
{
    public void SetDifficultyEasy() {
        PlayerPrefs.SetInt("spawnX", 3);
    }
    public void SetDifficultyMedium() {
        PlayerPrefs.SetInt("spawnX", 2);
    }
    public void SetDifficultyHard() {
        PlayerPrefs.SetInt("spawnX", 1);
    }
}

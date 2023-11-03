using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class timer : MonoBehaviour
{
    public TMP_Text tex;
    float timerText = 0;
    public float timerVal = 0;

    // Update is called once per frame
    void Update() {
        timerVal += Time.deltaTime;
        timerText = Mathf.FloorToInt(timerVal);
        tex.text = timerText.ToString();
    }
}

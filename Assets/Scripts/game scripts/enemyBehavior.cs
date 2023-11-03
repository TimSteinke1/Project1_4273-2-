using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehavior : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rbE;

    void Start()
    {
        rbE.velocity = -1 * transform.right * speed;
    }
}

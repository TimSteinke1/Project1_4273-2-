using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowUpBehavior : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rbE;
    // Start is called before the first frame update
    void Start()
    {
        rbE.velocity = -1 * transform.right * speed;
    }

}

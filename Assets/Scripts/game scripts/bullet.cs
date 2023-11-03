using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float speed = 20f;
    public float damage = 1f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Physics2D.IgnoreLayerCollision(1,2);
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}

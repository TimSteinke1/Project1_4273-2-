using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovements : MonoBehaviour
{
    public float speed;
    private Vector2 moveInput;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb.velocity = moveInput * speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D CatJump2D;
    float jumpForce = 600.0f;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.CatJump2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.CatJump2D.AddForce(transform.up * this.jumpForce);
        }
        int key = 0;
    }
}

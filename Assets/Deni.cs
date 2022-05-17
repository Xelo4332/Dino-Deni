using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deni : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isGrounded;
    [SerializeField]
    private KeyCode jump;
    // Start is called before the first frame update
    [SerializeField]
    float jumpMulti;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(jump) && isGrounded)
        {
            rb.AddForce(Vector2.up * jumpMulti);
            print("jump");
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        print("on ground");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        print("off ground");
    }
}

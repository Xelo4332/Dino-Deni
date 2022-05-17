using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deni : MonoBehaviour
{
    private Rigidbody2D rb;
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
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector2.up * jumpMulti);
            print("jump");
        }
    }
}

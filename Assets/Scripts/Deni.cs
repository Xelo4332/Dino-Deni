using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deni : MonoBehaviour //Simon och Deni
{
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _checkRadius;
    [SerializeField] private Transform _groundChecker;
    [SerializeField] private LayerMask _groundLayer;
    private bool isJump;
    private int jumpIteration;
    [SerializeField] private int jumpIterationCount;
    private bool _isGround;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
       

    }
    //Hop methoden, om man trycker W då kommer karaktären hoppa. Men att hoppa måste man ha is jump true- Simon
    private void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (_isGround)
            { 
                isJump = true;
            }

        }
        else
        {
            isJump = false;
        }

        if (isJump) //JumpItercation is for create mario jump mechanic, the jump feels better everytime you jump Deni
        {
            if (jumpIteration++ < jumpIterationCount)
            {
                _rigidbody.AddForce(Vector2.up * _jumpForce / jumpIteration);

            }
        }
        else
        {
            jumpIteration = 0;
        }


    }

    //If player collide with ground, then jump method activates - Simon
    private void CheckingGround()
    {
        _isGround = Physics2D.OverlapCircle(_groundChecker.position, _checkRadius, _groundLayer);
    }

    private void Update()
    {
        CheckingGround();
        Jump();
    }
}

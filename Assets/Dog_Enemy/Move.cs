using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Lets you chose the direction to move the dog in
    [SerializeField]
    private Vector3 move;

    void Start()
    {
        //Moves the dog on the first frame
        transform.position += move;
    }

    // Update is called once per frame
    void Update()
    {
        //Moves the dog every frame
        transform.position += move*Time.deltaTime;
    }
}

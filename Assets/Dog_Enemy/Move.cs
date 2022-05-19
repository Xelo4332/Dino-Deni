using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        transform.position += move;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += move*Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject thingToSpawn;
    [SerializeField]
    private float  maxRandomNumber;
    [SerializeField]
    private float cooldown;
    private float cooldownTimer = 0;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownTimer < 0)
        {
            Instantiate(thingToSpawn, transform.position, transform.rotation);
            cooldownTimer = cooldown;
            cooldownTimer -= Random.Range(0,cooldown/2);
            print("done");
        }
        else
        {
            cooldownTimer -= 1*Time.deltaTime;
        }
    }
}

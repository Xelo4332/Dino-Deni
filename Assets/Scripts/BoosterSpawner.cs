using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Deni och Simon gjorde scripten tillsammans för att det var lite kompleserat matte
public class BoosterSpawner : MonoBehaviour
{
    [SerializeField] private Booster[] boosters; // array of spawn
    [SerializeField] private float minSpawnInterval; //min spawn interval
    [SerializeField] private float maxSpawnInterval;//max spawn interval

    private void Start()
    {
        StartCoroutine(Spawn()); //Start spawn coroutine

    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(10);
        while (true) // infinite cicle
        {
            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);// calculate random value between min and max intervals
            int randomBoosterIndex = Random.Range(0, boosters.Length); //calculate random index of spawn object array
            yield return new WaitForSeconds(spawnInterval);// wait before spawn 
            GameObject booster = Instantiate(boosters[randomBoosterIndex].gameObject, transform.position, Quaternion.identity); // create objects
            Destroy(booster, 5); //Destroy object after 5 seconds
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterSpawner : MonoBehaviour
{
    [SerializeField] private Booster[] boosters;
    [SerializeField] private float minSpawnInterval;
    [SerializeField] private float maxSpawnInterval;

    private void Start()
    {
        StartCoroutine(Spawn());

    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(10);
        while (true)
        {
            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            int randomBoosterIndex = Random.Range(0, boosters.Length);
            yield return new WaitForSeconds(spawnInterval);
            GameObject booster = Instantiate(boosters[randomBoosterIndex].gameObject, transform.position, Quaternion.identity);
            Destroy(booster, 5);
        }
    }
}

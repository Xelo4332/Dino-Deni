using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Exakt samma script som BoosterSpawner med har inte yield return före while
public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private float minSpawnInterval;
    [SerializeField] private float maxSpawnInterval;

    private void Start()
    {
        StartCoroutine(Spawn());

    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            float spawnInterval = Random.Range(minSpawnInterval, maxSpawnInterval);
            int randomObstacleIndex = Random.Range(0, obstacles.Length);
            yield return new WaitForSeconds(spawnInterval);
            GameObject obstacle = Instantiate(obstacles[randomObstacleIndex], transform.position, Quaternion.identity);
            Destroy(obstacle, 5);
        }
    }

}


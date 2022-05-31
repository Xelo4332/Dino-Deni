using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeeder : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    private float speedBoostInterval = 2.0f;

    private void Start()
    {
        StartCoroutine(SpeedBoost());//Starta speed ökning

    }
    private IEnumerator SpeedBoost()
    {
        while (Time.timeScale < maxSpeed)//Om timescale är mindre än maxspeed som kommer koden nere funka, men om timescalse blir exakt samma värde som maxspeed då
        //kommer det sluta ökas
        {
            yield return new WaitForSeconds(speedBoostInterval); //Hur mycket sekunder vänta tills det ska ökas hastighet på spel
            Time.timeScale += 0.1f;//Tid ökning
        }
    }

}

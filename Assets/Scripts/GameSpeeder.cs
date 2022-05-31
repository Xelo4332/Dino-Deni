using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeeder : MonoBehaviour
{
    [SerializeField] private float maxSpeed;
    private float speedBoostInterval = 2.0f;

    private void Start()
    {
        StartCoroutine(SpeedBoost());//Starta speed �kning

    }
    private IEnumerator SpeedBoost()
    {
        while (Time.timeScale < maxSpeed)//Om timescale �r mindre �n maxspeed som kommer koden nere funka, men om timescalse blir exakt samma v�rde som maxspeed d�
        //kommer det sluta �kas
        {
            yield return new WaitForSeconds(speedBoostInterval); //Hur mycket sekunder v�nta tills det ska �kas hastighet p� spel
            Time.timeScale += 0.1f;//Tid �kning
        }
    }

}

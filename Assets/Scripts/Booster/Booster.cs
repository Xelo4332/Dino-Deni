using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Booster : MonoBehaviour
    //Deni
{// vi skapar ett abstract class som kommer inte ha sitt egen kropp i methoden som kommer användar i slow boost

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            ApplyEffect();
        }


    }

    public abstract void ApplyEffect();// 

}

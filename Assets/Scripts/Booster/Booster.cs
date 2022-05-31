using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Booster : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            ApplyEffect();
        }


    }

    public abstract void ApplyEffect();

}

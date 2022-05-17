using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverHitbox : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)  //Colidder for adding point if enemy will collide with bullet
    {
        if (col.tag == "Stenstam")//If Alien will tag with bullet then alien will play audio source, play animation death and then destroy the object.
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");

        }
    }
}  


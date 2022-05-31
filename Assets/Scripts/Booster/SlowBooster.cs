using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBooster : Booster
{
    //Deni
    [SerializeField] private float duration;
    private GameSpeeder animationC; //This class boost speed of our game
    private Coroutine effectRoutine;

    private void Start()
    {
        animationC = FindObjectOfType<GameSpeeder>();
    }

    public override void ApplyEffect() // this is realzize of abstract class from parent class booster
    {
        if (effectRoutine == null) // if effectRoutine field is empty
        {
            effectRoutine = StartCoroutine(EffectRoutine());// start effect routine
        }

    }

    private IEnumerator EffectRoutine()
    {
        animationC.enabled = false;// disable class who boost speed of game
        float currentTimeScale = Time.timeScale;// save current speed of game
        Time.timeScale = 0.5f;// change speed of your game to 0.5
        yield return new WaitForSeconds(duration);// wait duration
        Time.timeScale = currentTimeScale;// return speed of game
        animationC.enabled = true;//enable class who boost speed of game
        if (effectRoutine != null)//if effectRoutine is not empty
        {
            StopCoroutine(effectRoutine);//stop effect routine
            effectRoutine = null;//initailize empty value in effectRoutine field
        }
    }


}

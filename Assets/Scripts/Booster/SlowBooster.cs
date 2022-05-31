using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowBooster : Booster
{

    [SerializeField] private float duration;
    private GameSpeeder animationC;
    private Coroutine effectRoutine;

    private void Start()
    {
        animationC = FindObjectOfType<GameSpeeder>();
    }

    public override void ApplyEffect()
    {
        if (effectRoutine == null)
        {
            effectRoutine = StartCoroutine(EffectRoutine());
        }

    }

    private IEnumerator EffectRoutine()
    {
        animationC.enabled = false;
        float currentTimeScale = Time.timeScale;
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(duration);
        Time.timeScale = currentTimeScale;
        animationC.enabled = true;
        if (effectRoutine != null)
        {
            StopCoroutine(effectRoutine);
            effectRoutine = null;
        }
    }


}

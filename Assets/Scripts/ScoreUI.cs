using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    
    [SerializeField] private Text _timerLabel;
    private int _time;

    private int timerScore; private void Start()
    {
        
        
        StartCoroutine(Tick());
    }
    //And number value +1
    private IEnumerator Tick()
    {
        while (true)
        {
            _time++;
            yield return new WaitForSeconds(1);
            _timerLabel.text = _time.ToString();
        }
    }
    //Saves record
    private void Save()
    {
        PlayerPrefs.SetInt("record", _time);
    }
    //Destroying Timer when player is dead
    
}



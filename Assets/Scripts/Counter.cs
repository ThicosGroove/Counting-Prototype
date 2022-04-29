using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counter : MonoBehaviour
{
    public TMP_Text CounterText;

    private int Count = 0;

    private void Start()
    {
        Count = 0;


        if (CounterText != null)
        {
            CounterText.text = Count.ToString();
        }      
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1;
        CounterText.text = Count.ToString();
    }
}

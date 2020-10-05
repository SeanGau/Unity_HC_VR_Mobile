using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleDie : MonoBehaviour
{
    private ParticleSystem[] flames;
    private void Awake()
    {
        flames = this.GetComponentsInChildren<ParticleSystem>();
    }
    public void dieCandles()
    {
        foreach (var item in flames)
        {
            var emission = item.emission;
            emission.enabled = false;
        }
    }
}

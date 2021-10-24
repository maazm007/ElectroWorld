using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay3 : MonoBehaviour
{
    public ParticleSystem Target1,Target2;

    void Start()
    {
        Target1.Pause();
        Target2.Pause();
        Invoke("DelayObject", 40.0f);
    }
    public void DelayObject()
    {
        Target1.Play();
        Target2.Play();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay4 : MonoBehaviour
{
    public ParticleSystem Target1, Target2, Target3;

    void Start()
    {
        Target1.Pause();
        Target2.Pause();
        Target3.Pause();
        Invoke("DelayObject", 16.0f);
    }
    public void DelayObject()
    {
        Target1.Play();
        Target2.Play();
        Target3.Play();
    }
}

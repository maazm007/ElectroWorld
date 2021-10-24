using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay2 : MonoBehaviour
{
    public ParticleSystem Target;

    void Start()
    {
        Target.Pause();
        Invoke("DelayObject", 26.0f);
    }
    public void DelayObject()
    {
        Debug.Log("Start");
        Target.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public ParticleSystem Target;

    void Start()
    {
        Target.Pause();
        Invoke("DelayObject", 34.0f);
    }
    public void DelayObject()
    {
        Debug.Log("Start");
        Target.Play();
    }

}

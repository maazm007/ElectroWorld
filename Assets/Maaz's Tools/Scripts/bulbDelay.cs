using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulbDelay : MonoBehaviour
{
    public Light Target;
    // Start is called before the first frame update
    void Start()
    {
        Target.enabled = false;
        Invoke("lightOnOff", 48.0f);
    }

    public void lightOnOff()
    {
        Target.enabled = true;
    }

  
}

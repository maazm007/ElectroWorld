using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disableBegin : MonoBehaviour
{
    public Button myButton;

    void Start()
    {
        myButton = GetComponent<Button>();    
    }

    void Update()
    {
        myButton.enabled = false;    
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationSlider1 : MonoBehaviour
{
    private Slider rotateSlider;
    public float rotMinValue;
    public float rotMaxValue;
    
    
   
    void Start()
    {
        rotateSlider = GameObject.Find("RotateSlider1").GetComponent<Slider>();
        rotateSlider.minValue = rotMinValue;
        rotateSlider.maxValue = rotMaxValue;
        rotateSlider.onValueChanged.AddListener(RotateSlider1Update);
    }

    void RotateSlider1Update(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
}

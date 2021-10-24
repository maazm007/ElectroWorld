using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HIDETEXT : MonoBehaviour
{
    public GameObject CLOSE;
    public void hideButton()
    {
        CLOSE.gameObject.SetActive(false); 
    }
    
}

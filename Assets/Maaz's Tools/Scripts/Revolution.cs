using UnityEngine;
using System.Collections;

public class Revolution : MonoBehaviour
{

    public Transform target; // the object to rotate around
    public float speed; // the speed of rotation

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}

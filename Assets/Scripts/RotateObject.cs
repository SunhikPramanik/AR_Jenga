using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField]
    private float rotationAngle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateRight()
    {
        /*GameObject.FindGameObjectWithTag("modelObject").*/this.transform.Rotate(0,rotationAngle,0);
        Debug.Log("1");
    }

    public void RotateLeft()
    {
        /*GameObject.FindGameObjectWithTag("modelObject").*/this.transform.Rotate(0, -rotationAngle, 0);
        Debug.Log("-1");
    }
}

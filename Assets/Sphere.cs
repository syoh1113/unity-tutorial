using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowMyName(string itsName)
    {
        Debug.Log("My name is " + gameObject.name);
        Debug.Log("My name is " + itsName);
    }
}

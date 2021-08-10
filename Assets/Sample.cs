using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample : MonoBehaviour
{
    [System.NonSerialized]
    public int indexNumber = 10;

    [System.NonSerialized]
    public string myName = "Gomdol";

    // 마우스 클릭
    void OnMouseDown()
    {
        Debug.Log("New Clicked");
    }

    // 마우스 뗄때
    void OnMouseUp()
    {
        Debug.Log("Mouse Up");
    }

    // 마우스 진입
    void OnMouseEnter()
    {
        Debug.Log("Mouse entered!");
    }

    // 마우스 탈출
    void OnMouseExit()
    {
        Debug.Log("Mouse out!");
    }

    // Start is called before the first frame update
    void Start()
    {
        indexNumber = 20;
        myName = "Kim";
        Debug.Log(myName);

        GameObject cube = GameObject.FindWithTag("cubeTag");
        Debug.Log(cube.name);

        cube.SendMessage("ShowMyName", "Mr.Kim");

        cube.GetComponent<Sphere>().ShowMyName("James");
    }

    void ShowMyName()
    {
        indexNumber = 40;
        myName = "Tom";

        float distanceOfit = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

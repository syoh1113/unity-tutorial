using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Transform playerTransform;
    Vector3 offset;

    void Awake()
    {
        playerTransform = GameObject.FindGameObjectWithTag("playerTag").transform;
        this.offset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {
        transform.position = playerTransform.position + this.offset;
    }
}

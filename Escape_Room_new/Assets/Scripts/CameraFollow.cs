using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform targetObjects;
    public Vector3 cameraOffset;
    public float smootheFactor = 0.5f;
    public bool lookAtTarget = false;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = transform.position - targetObjects.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = targetObjects.transform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position,newPosition, smootheFactor);
        if (lookAtTarget)
        {
            transform.LookAt(targetObjects);
        }
    }
}

using System;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{
    public GameObject target;
    private Camera camera;

    void Start()
    {
        camera = Camera.main;
    }
    void LateUpdate()
    
    {
        camera.transform.LookAt(transform.position);
        transform.LookAt(transform.position + target.transform.rotation * Vector3.forward, target.transform.rotation * Vector3.up);
    }
}

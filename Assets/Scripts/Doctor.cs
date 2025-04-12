using System;
using UnityEngine;

public class Doctor : MonoBehaviour
{
    public static int currentStep;
    public static bool noTextLeft;
    public Canvas _canvas;
    Animator animator;
    [Header("Text Cloud to hide while moving.")] public GameObject textCloud;
    [Header("chair to move gameobject")] public Transform chair;

    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void MoveToSit()
    {
        // hidefd the text ui
        textCloud.SetActive(false);
        float distance = Vector3.Distance(transform.position, chair.position);
        if (distance > 1.0f)
        {
            animator.SetBool("walking", true);
            transform.position = Vector3.MoveTowards(transform.position, chair.position, 2f * Time.deltaTime);
            transform.LookAt(chair.position);
        }
        else
        {
            animator.SetBool("walking", false);
            StartCoroutine("showImage", 6.0f);
        }
        
    }

    private void FixedUpdate()
    {
        if (noTextLeft)
        MoveToSit();
        
    }

    private void showImage()
    {
        _canvas.gameObject.SetActive(true);
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool cleared;
    private bool jammed;

    Animator animator;

    void Start()
    {
        cleared = false;
        jammed = false;
        animator = GetComponent<Animator>();

        CodeLock codeLock = FindObjectOfType<CodeLock>();
        codeLock.Clear += Unlock;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("마우스 입력");
            Debug.Log(jammed);
            if (!jammed)
            {
                DoorOpenClose();
            }else
            {
                Debug.Log("망함");
            }
        }
    }


    void DoorOpenClose()
    {
        animator.SetTrigger("DoorTrigger");

        if (!cleared)
        {
            cleared = true;
        }
    }

    void Unlock()
    {
        jammed = false;
    }
}

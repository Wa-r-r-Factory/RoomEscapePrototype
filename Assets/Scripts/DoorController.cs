using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private bool jammed;

    Animator animator;

    public event Action LevelClear;


    void Start()
    {
        jammed = true;
        animator = GetComponent<Animator>();

        CodeLock codeLock = FindObjectOfType<CodeLock>();
        codeLock.Clear += Unlock;

        DoorSwitch doorSwitch = FindObjectOfType<DoorSwitch>();
        doorSwitch.OpenIt += DoorOpenClose;
    }


    public void DoorOpenClose()
    {
        if (!jammed)
        {
            animator.SetTrigger("DoorTrigger");
        }
        else
        {
            Debug.Log("문이 잠겨있습니다.");
        }

    }

    void Unlock()
    {
        jammed = false;
    }
}

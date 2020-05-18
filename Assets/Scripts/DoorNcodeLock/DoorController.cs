using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animator;
    public bool isOpened;
    public bool isJammed;

    public CodeLock codeLock;
    public DoorSwitch[] doorSwitchs;

    private void Start()
    {
        animator = GetComponent<Animator>();
        isOpened = false;
        isJammed = true;

        codeLock.Clear += unjam;
        foreach(DoorSwitch d in doorSwitchs)
        {
            d.Clicked += DoorTrigger;
        }
    }

    private void unjam()
    {
        isJammed = false;
    }

    public void DoorTrigger()
    {
        if (!isJammed)
        {
            OpenClose();
        }
        else
        {
            Debug.Log("문이 잠겨있습니다.");
        }
    }

    private void OpenClose()
    {
        isOpened = !isOpened;
        animator.SetTrigger("OpenClose");
    }

}

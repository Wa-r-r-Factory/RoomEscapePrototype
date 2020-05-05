using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeLock : MonoBehaviour
{
    int placeInCode;
    int codeLength;

    public string code = "";
    public string attemptedCode;

    Animator animator;

    public event Action Clear;

    Text panel;

    private void Start()
    {
        codeLength = code.Length;

        panel = GetComponentInChildren<Text>();
        animator = GetComponentInChildren<Animator>();
    }

    // Start is called before the first frame update



    public void SetValue(string value)
    {
        if (placeInCode <= codeLength && value != "Keypad" && panel.text.Length == placeInCode)
        {
            attemptedCode += value;
            panel.text = attemptedCode;

            placeInCode++;
        }

        if (placeInCode == codeLength)
        {
            Invoke("CheckCode", 1f);

            placeInCode = 0;
        }
    }

    void CheckCode()
    {
        if (attemptedCode == code)
        {
            Clear();
        }
        else
        {
            Debug.Log("틀린 비밀번호입니다.");
            animator.SetBool("Wrong", true);
        }

        Invoke("ResetPanel", 1f);
    }

    private void ResetPanel()
    {
        attemptedCode = "";
        panel.text = "";
        animator.SetBool("Wrong", false);
    }
}

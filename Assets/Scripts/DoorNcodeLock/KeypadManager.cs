using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//메인 카메라에서 사용됩니다.

public class KeypadManager : MonoBehaviour
{
    CodeLock codeLock;

    int reachRange = 100;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckHitObj();
        }
    }

    void CheckHitObj()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, reachRange))
        {
            codeLock = hit.transform.gameObject.GetComponentInParent<CodeLock>();

            if (codeLock != null)
            {
                string value = hit.transform.name; //버튼의 이름을 숫자로 설정해서 CodeLock의 SetValue 메소들로 보냈어요.
                codeLock.SetValue(value);
            }
        }
    }
}

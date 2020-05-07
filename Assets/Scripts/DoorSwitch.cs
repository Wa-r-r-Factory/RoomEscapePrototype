using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    public event Action OpenIt;

    public GameObject openSwich;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 10))
            {
                if (hit.transform.gameObject.tag == "switch"){
                    OpenIt();
                }
            }
        }
    }


}

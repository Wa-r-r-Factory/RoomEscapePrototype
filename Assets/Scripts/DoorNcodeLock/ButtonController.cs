using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject Video;

    private void Start()
    {
        Video.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 10)){
                GameObject o = hit.transform.gameObject;

                if(o == gameObject)
                {
                    Video.SetActive(true);
                }
            }
        }
    }
}

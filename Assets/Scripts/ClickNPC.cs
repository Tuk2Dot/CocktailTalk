using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNPC : MonoBehaviour
{
    public Camera getCamera;

    private RaycastHit hit;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                Debug.Log(hit.collider.name);
            }
        }
    }
}

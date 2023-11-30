using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameWarningManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void WarningOpen()
    {
        gameObject.SetActive(true);
    }


    public void WarningClose()
    {
        gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDataManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void NewGame()
    {
        gameObject.SetActive(true);
    }

    public void ExitNewGame()
    {
        gameObject.SetActive(false);
    }
}

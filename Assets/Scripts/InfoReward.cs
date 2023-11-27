using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoReward : MonoBehaviour
{
    Text temp;

    private static InfoReward instance;
    public static InfoReward Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        GameObject infoText = GameObject.Find("infotext");
        temp = infoText.GetComponent<Text>();

        gameObject.SetActive(false);
        instance = this;

    }

    public void PopupReward(string s)
    {   
        gameObject.SetActive(true);
        temp.text = "모든 대화가 종료되었습니다.\n획득한 리워드 : " + s + "\n클릭하면 손님 선택 화면으로 이동합니다.";     
    }
}
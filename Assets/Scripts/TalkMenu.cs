using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TalkMenu : MonoBehaviour
{
    public TMP_Text MoneyUI; //자금 표시
    public GameObject Card;
    public TMP_Text CardInfo;

    private void Start()
    {
        MoneyUI.text = " Money: " + PlayerPrefs.GetInt("Money").ToString(); //UI에 표기
        Card.SetActive(false);
    }
    public void CardButton() //명함 정보 보기
    {
        bool HaveCost = DataManager.instance.SetMoney(-2);
        if (HaveCost)
        {
            MoneyUI.text = " Money: " + PlayerPrefs.GetInt("Money").ToString(); //UI에 표기

            string[] visitor = DataManager.instance.GetVisitorData();
            CardInfo.text = "  주제 : " + visitor[2] + "\n\n  직장 : " + visitor[4] + "\n\nMBTI :" + visitor[3];

            Card.SetActive(true);
        }
    }

    public void CardClose()
    {
        Card.SetActive(false);
    }
    public void TestButton() // 테스트 버튼
    {
        DataManager.instance.SetMoney(10);
        MoneyUI.text = " Money: " + PlayerPrefs.GetInt("Money").ToString(); //UI에 표기
        Debug.Log(PlayerPrefs.GetInt("Money"));
    }
}

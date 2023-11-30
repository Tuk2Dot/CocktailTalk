using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TalkMenu : MonoBehaviour
{
    public TMP_Text MoneyUI; //�ڱ� ǥ��
    public GameObject Card;
    public TMP_Text CardInfo;

    private void Start()
    {
        MoneyUI.text = " Money: " + PlayerPrefs.GetInt("Money").ToString(); //UI�� ǥ��
        Card.SetActive(false);
    }
    public void CardButton() //���� ���� ����
    {
        bool HaveCost = DataManager.instance.SetMoney(-2);
        if (HaveCost)
        {
            MoneyUI.text = " Money: " + PlayerPrefs.GetInt("Money").ToString(); //UI�� ǥ��

            string[] visitor = DataManager.instance.GetVisitorData();
            CardInfo.text = "  ���� : " + visitor[2] + "\n\n  ���� : " + visitor[4] + "\n\nMBTI :" + visitor[3];

            Card.SetActive(true);
        }
    }

    public void CardClose()
    {
        Card.SetActive(false);
    }
    public void TestButton() // �׽�Ʈ ��ư
    {
        DataManager.instance.SetMoney(10);
        MoneyUI.text = " Money: " + PlayerPrefs.GetInt("Money").ToString(); //UI�� ǥ��
        Debug.Log(PlayerPrefs.GetInt("Money"));
    }
}

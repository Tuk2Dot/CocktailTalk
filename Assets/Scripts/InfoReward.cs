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
        temp.text = "��� ��ȭ�� ����Ǿ����ϴ�.\nȹ���� ������ : " + s + "\nŬ���ϸ� �մ� ���� ȭ������ �̵��մϴ�.";     
    }
}
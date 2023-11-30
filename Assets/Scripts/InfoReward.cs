using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        int total = int.Parse(s);
        if (total <= 0)
            total = 0;
        DataManager.instance.SetMoney(total);
        temp.text = "��� ��ȭ�� ����Ǿ����ϴ�.\nȹ���� ������ : " + total.ToString() + "\nŬ���ϸ� �մ� ���� ȭ������ �̵��մϴ�.";     
    }
    public void ExitTalk()
    {
        SceneManager.LoadScene("CocktailTalk");
    }
}
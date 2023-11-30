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
        temp.text = "모든 대화가 종료되었습니다.\n획득한 리워드 : " + total.ToString() + "\n클릭하면 손님 선택 화면으로 이동합니다.";     
    }
    public void ExitTalk()
    {
        SceneManager.LoadScene("CocktailTalk");
    }
}
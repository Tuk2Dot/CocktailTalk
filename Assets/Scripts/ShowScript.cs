using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScript : MonoBehaviour
{    
    string visitor = "visitor1";    //손님 이름 저장
    string path;
    string[] scriptList;
    Text strText;
    int count = 0;

    private void Awake()
    {
        path = @"Assets/Script/" + visitor + "_Q.txt";
        scriptList = System.IO.File.ReadAllLines(path);

        GameObject scriptText = GameObject.Find("ScriptText");
        strText = scriptText.GetComponent<Text>();
    }

    public void ScriptTextButton()
    {
        if (count >= scriptList.Length)
        {
            int r = GameObject.Find("SumReward").GetComponent<SumReward>().totalReward;
            string s = r.ToString();
            //GameObject.Find("InfoReward").GetComponent<InfoReward>().PopupReward(s);
            InfoReward.Instance.PopupReward(s);
        }

        else
        {
            strText.text = scriptList[count];
            GameObject.Find("SelectText1").GetComponent<SelectText1>().Select1Show(count);
            GameObject.Find("SelectText2").GetComponent<SelectText2>().Select2Show(count);
            GameObject.Find("SelectText3").GetComponent<SelectText3>().Select3Show(count);
            count++;
        }
    }

    public void ShowAnswer(string answer)
    {
        strText.text = answer;
    }

}

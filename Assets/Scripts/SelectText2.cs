using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectText2 : MonoBehaviour
{
    string visitor;   //손님 이름 저장
    string path_select2, path_emotion2;
    string[] selectList, emotionList;
    Text strText;
    string tempstr;
    int count = 0;
    int reward = 0;

    private void Awake()
    {
        string[] visitorNum = DataManager.instance.GetVisitorData();
        visitor = "visitor" + visitorNum[0];

        path_select2 = Application.dataPath + "/Resources/" + visitor + "_A2.txt";
        selectList = System.IO.File.ReadAllLines(path_select2);

        path_emotion2 = Application.dataPath + "/Resources/" + visitor + "_E2.txt";
        emotionList = System.IO.File.ReadAllLines(path_emotion2);

        GameObject select2 = GameObject.Find("Select2");
        strText = select2.GetComponent<Text>();
    }

    public void Select2Show(int c)
    {
        strText.text = selectList[c];
        count = c;
    }

    public void Select2Button()
    {
        tempstr = emotionList[count * 2];
        reward = Convert.ToInt32(emotionList[count * 2 + 1]);

        GameObject.Find("ShowScript").GetComponent<ShowScript>().ShowAnswer(tempstr);
        GameObject.Find("SumReward").GetComponent<SumReward>().sumReward(reward);
        GameObject.Find("ShowEmotion").GetComponent<ShowEmotion>().ShowEmoji(reward);
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectText1 : MonoBehaviour
{
    string visitor;    //손님 이름 저장
    string path_select1, path_emotion1;
    string[] selectList, emotionList;
    Text strText;
    string tempstr;
    int count = 0;
    int reward = 0;

    private void Awake()
    {
        string[] visitorNum = DataManager.instance.GetVisitorData();
        visitor = "visitor" + visitorNum[0];

        path_select1 = Application.streamingAssetsPath + "/" + visitor + "_A1.txt";
        selectList = System.IO.File.ReadAllLines(path_select1);

        path_emotion1 = Application.streamingAssetsPath + "/" + visitor + "_E1.txt";
        emotionList = System.IO.File.ReadAllLines(path_emotion1);

        GameObject select1 = GameObject.Find("Select1");
        strText = select1.GetComponent<Text>();
    }

    public void Select1Show(int c)
    {
        strText.text = selectList[c];
        count = c;
    }

    public void Select1Button()
    {
        tempstr = emotionList[count * 2];
        reward = Convert.ToInt32(emotionList[count * 2 + 1]);

        GameObject.Find("ShowScript").GetComponent<ShowScript>().ShowAnswer(tempstr);
        GameObject.Find("SumReward").GetComponent<SumReward>().sumReward(reward);
        GameObject.Find("ShowEmotion").GetComponent<ShowEmotion>().ShowEmoji(reward);
    }

}

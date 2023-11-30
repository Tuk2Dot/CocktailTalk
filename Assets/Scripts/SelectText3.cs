using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectText3 : MonoBehaviour
{
    string visitor;    //손님 이름 저장
    string path_select3, path_emotion3;
    string[] selectList, emotionList;
    Text strText;
    string tempstr;
    int count = 0;
    int reward = 0;

    private void Awake()
    {
        string[] visitorNum = DataManager.instance.GetVisitorData();
        visitor = "visitor" + visitorNum[0];

        path_select3 = Application.dataPath + "/Resources/" + visitor + "_A3.txt";
        selectList = System.IO.File.ReadAllLines(path_select3);

        path_emotion3 = Application.dataPath + "/Resources/" + visitor + "_E3.txt";
        emotionList = System.IO.File.ReadAllLines(path_emotion3);

        GameObject select3 = GameObject.Find("Select3");
        strText = select3.GetComponent<Text>();
    }

    public void Select3Show(int c)
    {
        strText.text = selectList[c];
        count = c;
    }

    public void Select3Button()
    {
        tempstr = emotionList[count * 2];
        reward = Convert.ToInt32(emotionList[count * 2 + 1]);

        GameObject.Find("ShowScript").GetComponent<ShowScript>().ShowAnswer(tempstr);
        GameObject.Find("SumReward").GetComponent<SumReward>().sumReward(reward);
        GameObject.Find("ShowEmotion").GetComponent<ShowEmotion>().ShowEmoji(reward);
    }

}

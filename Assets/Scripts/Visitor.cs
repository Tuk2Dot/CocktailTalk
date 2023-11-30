// NPC관련 클래스 및 파일

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Visitor : MonoBehaviour
{
    public TMP_Text Topictext;

    public int Visitor_ID;          //NPC 일련번호
    public string Visitor_Name;     //NPC 이름
    public string Visitor_Topic;    //NPC 대화 주제
    public string Visitor_MBTI;     //NPC mbti
    public string Visitor_Job;      //NPC 직장

    private void Awake()
    {
        Topictext.text = Visitor_Topic;
        Topictext.gameObject.SetActive(true);
    }

    public void GotoTalkScene()
    {
        DataManager.instance.SetVisiterData(Visitor_ID, Visitor_Name, Visitor_Topic, Visitor_MBTI, Visitor_Job);
        Topictext.gameObject.SetActive(false); //주제 정보 끄기
        SceneManager.LoadScene("TalkScene");
    }
}

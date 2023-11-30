// NPC���� Ŭ���� �� ����

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Visitor : MonoBehaviour
{
    public TMP_Text Topictext;

    public int Visitor_ID;          //NPC �Ϸù�ȣ
    public string Visitor_Name;     //NPC �̸�
    public string Visitor_Topic;    //NPC ��ȭ ����
    public string Visitor_MBTI;     //NPC mbti
    public string Visitor_Job;      //NPC ����

    private void Awake()
    {
        Topictext.text = Visitor_Topic;
        Topictext.gameObject.SetActive(true);
    }

    public void GotoTalkScene()
    {
        DataManager.instance.SetVisiterData(Visitor_ID, Visitor_Name, Visitor_Topic, Visitor_MBTI, Visitor_Job);
        Topictext.gameObject.SetActive(false); //���� ���� ����
        SceneManager.LoadScene("TalkScene");
    }
}

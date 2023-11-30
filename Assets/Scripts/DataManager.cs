//전체 데이터를 바꾸고 저장하는 파일입니다

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    public int V_ID;          //NPC 일련번호
    public string V_Name;     //NPC 이름
    public string V_Topic;    //NPC 대화 주제

    public string V_MBTI;     //NPC mbti
    public string V_Job;      //NPC 직장



    private void Awake() //게임 시작시 초기 데이터 설정 함수
    {
    // DataManager 싱글턴 설정
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else //시스템 상에 2개 이상 존재하면 안됨
        {
            if (instance != this)
                Destroy(this.gameObject);
        }

    //초기 데이터 세팅
        if (!PlayerPrefs.HasKey("Name")) //이름
        {
            PlayerPrefs.SetString("Name", null);
        }
        if (!PlayerPrefs.HasKey("Money")) //자원
        {
            PlayerPrefs.SetInt("Money", 0);
        }
        if (!PlayerPrefs.HasKey("IsEmpty")) //파일 존재 여부
        {
            PlayerPrefs.SetInt("IsEmpty", System.Convert.ToInt16(1)); //Unity에서 bool값 저장 방법
        }
        if (!PlayerPrefs.HasKey("IsNewbie")) //도움말 여부
        {
            PlayerPrefs.SetInt("IsNewbie", System.Convert.ToInt16(0)); //Unity에서 bool값 저장 방법
        }
        if (!PlayerPrefs.HasKey("Bgm_Volume")) //배경음
        {
            PlayerPrefs.SetFloat("Bgm_Volume", 0.5f);
        }
        if (!PlayerPrefs.HasKey("Effect_Volume")) //효과음
        {
            PlayerPrefs.SetFloat("Effect_Volume", 0.5f);
        }
    }
    public bool SetMoney(int Reward) // 돈을 관리하는 함수
    {
        int Money = PlayerPrefs.GetInt("Money");
        Money += Reward;
        if (Money < 0)
        {
            return false; //실패시 false
        }
        else
        {
            PlayerPrefs.SetInt("Money", Money);
            return true; //성공시 true
        }
    }

    public void SetVisiterData(int ID, string Name, string Topic, string MBTI, string Job)
    {
        V_ID = ID;
        V_Name = Name;
        V_Topic = Topic;
        V_MBTI = MBTI;
        V_Job = Job;        
    }
    public string[] GetVisitorData()
    {
        string[] info = { V_ID.ToString(), V_Name, V_Topic, V_MBTI, V_Job };
        return info;
    }    
} 
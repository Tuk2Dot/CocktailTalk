//��ü �����͸� �ٲٰ� �����ϴ� �����Դϴ�

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    public static DataManager instance = null;

    public int V_ID;          //NPC �Ϸù�ȣ
    public string V_Name;     //NPC �̸�
    public string V_Topic;    //NPC ��ȭ ����

    public string V_MBTI;     //NPC mbti
    public string V_Job;      //NPC ����



    private void Awake() //���� ���۽� �ʱ� ������ ���� �Լ�
    {
    // DataManager �̱��� ����
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else //�ý��� �� 2�� �̻� �����ϸ� �ȵ�
        {
            if (instance != this)
                Destroy(this.gameObject);
        }

    //�ʱ� ������ ����
        if (!PlayerPrefs.HasKey("Name")) //�̸�
        {
            PlayerPrefs.SetString("Name", null);
        }
        if (!PlayerPrefs.HasKey("Money")) //�ڿ�
        {
            PlayerPrefs.SetInt("Money", 0);
        }
        if (!PlayerPrefs.HasKey("IsEmpty")) //���� ���� ����
        {
            PlayerPrefs.SetInt("IsEmpty", System.Convert.ToInt16(1)); //Unity���� bool�� ���� ���
        }
        if (!PlayerPrefs.HasKey("IsNewbie")) //���� ����
        {
            PlayerPrefs.SetInt("IsNewbie", System.Convert.ToInt16(0)); //Unity���� bool�� ���� ���
        }
        if (!PlayerPrefs.HasKey("Bgm_Volume")) //�����
        {
            PlayerPrefs.SetFloat("Bgm_Volume", 0.5f);
        }
        if (!PlayerPrefs.HasKey("Effect_Volume")) //ȿ����
        {
            PlayerPrefs.SetFloat("Effect_Volume", 0.5f);
        }
    }
    public bool SetMoney(int Reward) // ���� �����ϴ� �Լ�
    {
        int Money = PlayerPrefs.GetInt("Money");
        Money += Reward;
        if (Money < 0)
        {
            return false; //���н� false
        }
        else
        {
            PlayerPrefs.SetInt("Money", Money);
            return true; //������ true
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
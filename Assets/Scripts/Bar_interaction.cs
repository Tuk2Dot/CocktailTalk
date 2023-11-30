//�ΰ��� ��Ʈ�� ����

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bar_interaction : MonoBehaviour
{
    public Camera getCamera; //���� ī�޶�
    private GameObject NPC;  //Ŭ���ϴ� ���
    public GameObject EndingButton; //�������� ��ư
    public GameObject EndingScene;
    public TMP_Text MoneyUI; //�ڱ� ǥ��
    public bool IsSettingOn = false; //�Ͻ������� Ŭ����� ����

    private RaycastHit hit;

    private void Start()
    {
        EndingScene.SetActive(false);
        EndingButton.SetActive(false);
        IsSettingOn = false; //����â ����
        MoneyUI.text = " Money: "+ PlayerPrefs.GetInt("Money").ToString(); //UI�� ǥ��
        IsEnding();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&!IsSettingOn)                                //���콺�� ��������
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition); //Unity Ray�Լ� ����
            if (Physics.Raycast(ray, out hit))                          //������ Ray�� ��ü�� �ε�������
            {
                if(hit.transform.gameObject.tag == "NPC")                //NPC�� �з� �Ǵ� ���� Ŭ�� ���� ���
                {
                    NPC = hit.transform.gameObject;                     //��Ʈ ��� ����
                    NPC.GetComponent<Visitor>().GotoTalkScene();        //NPC�� �ִ� ��ũ��Ʈ �Լ� ȣ��
                }
            }
        }
    }

    public void Pause()
    {
        IsSettingOn = !IsSettingOn;
    }

    public void TestButton() //���� Ȯ���� ���� �׽�Ʈ ��ư
    {
        DataManager.instance.SetMoney(10);
        MoneyUI.text = " Money: " + PlayerPrefs.GetInt("Money").ToString(); //UI�� ǥ��
        Debug.Log(PlayerPrefs.GetInt("Money"));
        IsEnding();
    }

    public void IsEnding()
    {
        if (PlayerPrefs.GetInt("Money") >= 50)
        EndingButton.SetActive(true);
    }

    public void GotoEnding()
    {
        EndingScene.SetActive(true);
        Debug.Log("����");
    }
}

//인게임 컨트롤 파일

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bar_interaction : MonoBehaviour
{
    public Camera getCamera; //메인 카메라
    private GameObject NPC;  //클릭하는 대상
    public GameObject EndingButton; //엔딩보는 버튼
    public GameObject EndingScene;
    public TMP_Text MoneyUI; //자금 표시
    public bool IsSettingOn = false; //일시정지시 클릭기능 정지

    private RaycastHit hit;

    private void Start()
    {
        EndingScene.SetActive(false);
        EndingButton.SetActive(false);
        IsSettingOn = false; //설정창 끄기
        MoneyUI.text = " Money: "+ PlayerPrefs.GetInt("Money").ToString(); //UI에 표기
        IsEnding();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&!IsSettingOn)                                //마우스가 눌렸을때
        {
            Ray ray = getCamera.ScreenPointToRay(Input.mousePosition); //Unity Ray함수 실행
            if (Physics.Raycast(ray, out hit))                          //생성된 Ray가 물체에 부딪쳤을때
            {
                if(hit.transform.gameObject.tag == "NPC")                //NPC로 분류 되는 것을 클릭 했을 경우
                {
                    NPC = hit.transform.gameObject;                     //히트 대상 지정
                    NPC.GetComponent<Visitor>().GotoTalkScene();        //NPC에 있는 스크립트 함수 호출
                }
            }
        }
    }

    public void Pause()
    {
        IsSettingOn = !IsSettingOn;
    }

    public void TestButton() //엔딩 확인을 위한 테스트 버튼
    {
        DataManager.instance.SetMoney(10);
        MoneyUI.text = " Money: " + PlayerPrefs.GetInt("Money").ToString(); //UI에 표기
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
        Debug.Log("엔딩");
    }
}

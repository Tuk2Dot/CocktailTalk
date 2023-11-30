using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void OnClickQuit() //메인화면에서 Quit 버튼 누르면 호출하는 함수. 종료확인 팝업 띄워줌
    {
        gameObject.SetActive(true);
    }

    public void ExitGame()//ExitCheck 팝업에서 '예'를 누를 시 호출. 게임 종료 함수
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }

    public void back()//ExitCheck 팝업에서 '아니오'를 누를 시 호출. 게임종료 확인창 끄는 함수
    {
        gameObject.SetActive(false);
    }
}

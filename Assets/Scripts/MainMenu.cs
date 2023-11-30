//메인 메뉴 구동에 관련된 파일입니다.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject NewNameInputUI; //이름 입력 창
    public GameObject WarningDeleteUI; //파일 삭제 Y/N 창
    public GameObject WarningQuitUI; //게임 종료 Y/N 창

    public InputField PlayerNameInput; //이름 입력 칸

    void Start() //시작시에 모든 팝업UI 비활성화
    {
        NewNameInputUI.SetActive(false);
        WarningDeleteUI.SetActive(false);
        WarningQuitUI.SetActive(false);
    }
    public void NewGame() //시작하기 버튼
    {
        if (System.Convert.ToBoolean(PlayerPrefs.GetInt("IsEmpty"))) //저장된 데이터가 없을시에
            NewNameInputUI.SetActive(true); //이름 입력 창 표시
        else
            WarningDeleteUI.SetActive(true); //있는경우 주의 문구 창 표시
    }
    public void LoadGame() //불러오기 버튼
    {
        if (!System.Convert.ToBoolean(PlayerPrefs.GetInt("IsEmpty"))) //저장 파일이 있는 경우에만
            SceneManager.LoadScene("CocktailTalk"); //게임 씬으로 이동
    }
    public void SetName() //이름 입력 완료 버튼
    {
        PlayerPrefs.SetString("Name", PlayerNameInput.text);    //이름 저장
        PlayerPrefs.SetInt("IsEmpty", System.Convert.ToInt16(0));   //파일 존재 여부 각인
        NewNameInputUI.SetActive(false);    //이름 입력UI 닫기

        SceneManager.LoadScene("CocktailTalk");     //바 내부 씬으로 이동
    }
    public void CancleButton() //취소 버튼
    {
        WarningDeleteUI.SetActive(false);
        NewNameInputUI.SetActive(false);
        WarningQuitUI.SetActive(false);
    }
    public void DeleteGame() //삭제하기 버튼
    {
        PlayerPrefs.SetString("Name", null); //모든 데이터 초기값으로 설정
        PlayerPrefs.SetInt("Money", 0);
        PlayerPrefs.SetInt("IsNewbie", System.Convert.ToInt16(0));
        PlayerPrefs.SetInt("IsEmpty", System.Convert.ToInt16(1));

        WarningDeleteUI.SetActive(false); //주의 창 비활성화
        NewNameInputUI.SetActive(true); //이름 입력 창 표시
    }

    public void QuitGame()  //게임종료 버튼
    {
        WarningQuitUI.SetActive(true);
    }

    public void EndProgram()    //종료 확인 버튼
    {
        #if UNITY_EDITOR //유니티 에디터 상에서 종료
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

}

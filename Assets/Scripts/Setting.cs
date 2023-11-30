// 설정 UI에 관련된 파일입니다

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public AudioSource musicSource; //배경음
    //public AudioSource EffectSource; //효과음 (미구현)

    public GameObject BarUI; //세팅 창
    public GameObject SettingUI; //세팅 창

    public Slider Music_Slider;
    //private bool IsWindow = false;  //전체화면 (미구현)

    private void Start() //시작시에 팝업 UI 비활성화
    {
        Music_Slider.value = PlayerPrefs.GetFloat("Bgm_Volume");
        musicSource.volume = Music_Slider.value; //음량 조절

        QuitOption();
    }

    public void SetMusicVolume(float volume) //volume변수는 unity 슬라이더처리
    {
        PlayerPrefs.SetFloat("Bgm_Volume", volume);
        musicSource.volume = volume; //음량 조절
    }
    /* public void SetEffectVolume(float volume) //효과음 미구현
    {
        EffectSource.volume = volume;
    } */

    public void OpenOption() //옵션 UI 열기
    {
        SettingUI.SetActive(true);
        BarUI.SetActive(false);
    }

    public void QuitOption() // 옵션 UI 닫기 버튼
    {
        SettingUI.SetActive(false);
        BarUI.SetActive(true);
    }

    public void GotoMain() //메인화면으로 나가기 버튼
    {
        SceneManager.LoadScene("Main"); //게임 씬으로 이동
    }
}

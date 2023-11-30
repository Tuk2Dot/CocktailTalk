// ���� UI�� ���õ� �����Դϴ�

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public AudioSource musicSource; //�����
    //public AudioSource EffectSource; //ȿ���� (�̱���)

    public GameObject BarUI; //���� â
    public GameObject SettingUI; //���� â

    public Slider Music_Slider;
    //private bool IsWindow = false;  //��üȭ�� (�̱���)

    private void Start() //���۽ÿ� �˾� UI ��Ȱ��ȭ
    {
        Music_Slider.value = PlayerPrefs.GetFloat("Bgm_Volume");
        musicSource.volume = Music_Slider.value; //���� ����

        QuitOption();
    }

    public void SetMusicVolume(float volume) //volume������ unity �����̴�ó��
    {
        PlayerPrefs.SetFloat("Bgm_Volume", volume);
        musicSource.volume = volume; //���� ����
    }
    /* public void SetEffectVolume(float volume) //ȿ���� �̱���
    {
        EffectSource.volume = volume;
    } */

    public void OpenOption() //�ɼ� UI ����
    {
        SettingUI.SetActive(true);
        BarUI.SetActive(false);
    }

    public void QuitOption() // �ɼ� UI �ݱ� ��ư
    {
        SettingUI.SetActive(false);
        BarUI.SetActive(true);
    }

    public void GotoMain() //����ȭ������ ������ ��ư
    {
        SceneManager.LoadScene("Main"); //���� ������ �̵�
    }
}

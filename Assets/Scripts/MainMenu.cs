//���� �޴� ������ ���õ� �����Դϴ�.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject NewNameInputUI; //�̸� �Է� â
    public GameObject WarningDeleteUI; //���� ���� Y/N â
    public GameObject WarningQuitUI; //���� ���� Y/N â

    public InputField PlayerNameInput; //�̸� �Է� ĭ

    void Start() //���۽ÿ� ��� �˾�UI ��Ȱ��ȭ
    {
        NewNameInputUI.SetActive(false);
        WarningDeleteUI.SetActive(false);
        WarningQuitUI.SetActive(false);
    }
    public void NewGame() //�����ϱ� ��ư
    {
        if (System.Convert.ToBoolean(PlayerPrefs.GetInt("IsEmpty"))) //����� �����Ͱ� �����ÿ�
            NewNameInputUI.SetActive(true); //�̸� �Է� â ǥ��
        else
            WarningDeleteUI.SetActive(true); //�ִ°�� ���� ���� â ǥ��
    }
    public void LoadGame() //�ҷ����� ��ư
    {
        if (!System.Convert.ToBoolean(PlayerPrefs.GetInt("IsEmpty"))) //���� ������ �ִ� ��쿡��
            SceneManager.LoadScene("CocktailTalk"); //���� ������ �̵�
    }
    public void SetName() //�̸� �Է� �Ϸ� ��ư
    {
        PlayerPrefs.SetString("Name", PlayerNameInput.text);    //�̸� ����
        PlayerPrefs.SetInt("IsEmpty", System.Convert.ToInt16(0));   //���� ���� ���� ����
        NewNameInputUI.SetActive(false);    //�̸� �Է�UI �ݱ�

        SceneManager.LoadScene("CocktailTalk");     //�� ���� ������ �̵�
    }
    public void CancleButton() //��� ��ư
    {
        WarningDeleteUI.SetActive(false);
        NewNameInputUI.SetActive(false);
        WarningQuitUI.SetActive(false);
    }
    public void DeleteGame() //�����ϱ� ��ư
    {
        PlayerPrefs.SetString("Name", null); //��� ������ �ʱⰪ���� ����
        PlayerPrefs.SetInt("Money", 0);
        PlayerPrefs.SetInt("IsNewbie", System.Convert.ToInt16(0));
        PlayerPrefs.SetInt("IsEmpty", System.Convert.ToInt16(1));

        WarningDeleteUI.SetActive(false); //���� â ��Ȱ��ȭ
        NewNameInputUI.SetActive(true); //�̸� �Է� â ǥ��
    }

    public void QuitGame()  //�������� ��ư
    {
        WarningQuitUI.SetActive(true);
    }

    public void EndProgram()    //���� Ȯ�� ��ư
    {
        #if UNITY_EDITOR //����Ƽ ������ �󿡼� ����
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

}

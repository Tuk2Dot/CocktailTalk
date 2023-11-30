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

    public void OnClickQuit() //����ȭ�鿡�� Quit ��ư ������ ȣ���ϴ� �Լ�. ����Ȯ�� �˾� �����
    {
        gameObject.SetActive(true);
    }

    public void ExitGame()//ExitCheck �˾����� '��'�� ���� �� ȣ��. ���� ���� �Լ�
    {
#if UNITY_EDITOR
    UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif

    }

    public void back()//ExitCheck �˾����� '�ƴϿ�'�� ���� �� ȣ��. �������� Ȯ��â ���� �Լ�
    {
        gameObject.SetActive(false);
    }
}

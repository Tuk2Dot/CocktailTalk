using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GotoTalkScene : MonoBehaviour
{
    public void StartTalk()
    {
        //Datamanager�� NPC �ڷ� ����
        SceneManager.LoadScene("Talk");
    }
}

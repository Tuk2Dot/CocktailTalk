using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GotoTalkScene : MonoBehaviour
{
    public void StartTalk()
    {
        //Datamanager에 NPC 자료 전송
        SceneManager.LoadScene("Talk");
    }
}

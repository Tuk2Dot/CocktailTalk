using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowEmotion : MonoBehaviour
{
    public GameObject Emotion_bad, Emotion_smile, Emotion_soso;
    
    void Start()
    {
        Emotion_bad.SetActive(false);
        Emotion_smile.SetActive(false);
        Emotion_soso.SetActive(false);
    }

    public void ShowEmoji(int i)
    {
        if (i == -1)
        {
            Emotion_bad.SetActive(true);
            Emotion_smile.SetActive(false);
            Emotion_soso.SetActive(false);
        }
        else if (i == 1)
        {
            Emotion_bad.SetActive(false);
            Emotion_smile.SetActive(false);
            Emotion_soso.SetActive(true);
        }
        else if (i == 2)
        {
            Emotion_bad.SetActive(false);
            Emotion_smile.SetActive(true);
            Emotion_soso.SetActive(false);
        }
    }
}
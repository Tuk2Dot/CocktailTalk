using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicSource;
    
    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

}

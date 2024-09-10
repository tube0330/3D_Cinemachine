using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public bool isPlaying = false;

    public void ClickVideo(bool isPlaying)
    {

        if(isPlaying)
        {
            videoPlayer.Play();
            print(isPlaying);
        }

        else
        {
            videoPlayer.Pause();
            print(isPlaying);
        }
    }
}

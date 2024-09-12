using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void ClickVideo()
    {

        if(videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }

        else
        {
            videoPlayer.Pause();
        }
    }
}

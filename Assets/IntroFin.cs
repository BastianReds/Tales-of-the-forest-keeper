using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFin : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject camera = GameObject.Find("Main Camera");

        var videoPlayer = camera.AddComponent<UnityEngine.Video.VideoPlayer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IntroFinish(UnityEngine.Video.VideoPlayer vp)
    {
        vp.playbackSpeed = vp.playbackSpeed / 10.0F;
    }
}

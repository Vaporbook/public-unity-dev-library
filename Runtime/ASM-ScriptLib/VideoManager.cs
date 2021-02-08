using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoManager : MonoBehaviour
{

    public UnityEngine.Video.VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponentInParent<UnityEngine.Video.VideoPlayer>();
        videoPlayer.frame = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

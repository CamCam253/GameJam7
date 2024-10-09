using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;


public class VidPlayer : MonoBehaviour
{

    [SerializeField] string videoFileName;
    // Start is called before the first frame update
    void Start()
    {
        PlayVideo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayVideo()
    {
        VideoPlayer vp = GetComponent<VideoPlayer>();

        if (vp)
        {
            string vPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
            UnityEngine.Debug.Log(vPath);
            vp.url = vPath;
            vp.Play();
            vp.loopPointReached += CheckOver;

        }

    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene(0);
    }
}

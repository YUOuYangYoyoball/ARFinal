using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; //與視訊播放有關的命名空間
using Vuforia; //使用Vuforia命名空間

public class VideoControlByVirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject videoPlane; //代表視訊播放平面的物件
    private VideoPlayer videoPlayer;
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    // Start is called before the first frame update
    void Start()
    {
        // Register with the virtual buttons TrackableBehaviour
    virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();
    for (int i = 0; i < virtualButtonBehaviours.Length; ++i)
    {
       virtualButtonBehaviours[i].RegisterEventHandler(this);
    }
    videoPlane = GameObject.Find("Video");
    videoPlayer = videoPlane.GetComponent<VideoPlayer>();
    videoPlayer.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
{
videoPlayer.Play();
}
public void OnButtonReleased(VirtualButtonBehaviour vb)
{
videoPlayer.Pause();
}
}

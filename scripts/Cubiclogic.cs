using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubiclogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            PlayMusic();//调用类型
        }
    }
    void PlayMusic()
    {
        AudioSource audio=this.GetComponent<AudioSource>();//获取當前物體组件
        //audio.mute = true;//静音
        //audio.loop = true;//循环播放
        if (audio.isPlaying)//如果正在播放
        {
            Debug.Log("* 停止播放音乐");//日志

            audio.Stop();
        }
        else
        {
            Debug.Log("* 开始播放音乐");//日志

            audio.Play();
        }
        audio.Play();//开始播放
    }
}

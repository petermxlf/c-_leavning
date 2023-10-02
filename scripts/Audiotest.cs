using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiotest : MonoBehaviour
{
    public AudioClip audiosuccess;//音频类型
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource audiosourse = GetComponent<AudioSource>();//获取音频
            audiosourse.PlayOneShot(audiosuccess);//播放音频
        }
        
    }
}

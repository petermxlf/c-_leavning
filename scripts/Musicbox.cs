using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicbox : MonoBehaviour
{
    public AudioClip[] songs;//音频数组
    // Start is called before the first frame update
    void Start()
    {
        if (songs == null||songs.Length==0)
        {
            Debug.Log("* 请在检查其中检查资源");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            Nextsong();
        }
    }
    void Nextsong()
    {
        //随机播放
        int index = Random.Range(0, songs.Length);//从第零个到第三个随机抽取一个
        AudioClip clip = this.songs[index];
        AudioSource ac = GetComponent<AudioSource>();
        ac.clip = this.songs[index];
        ac.Play();
        Debug.Log("* 播放：" + clip.name);
    }
}

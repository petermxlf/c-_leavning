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
            PlayMusic();//��������
        }
    }
    void PlayMusic()
    {
        AudioSource audio=this.GetComponent<AudioSource>();//��ȡ��ǰ���w���
        //audio.mute = true;//����
        //audio.loop = true;//ѭ������
        if (audio.isPlaying)//������ڲ���
        {
            Debug.Log("* ֹͣ��������");//��־

            audio.Stop();
        }
        else
        {
            Debug.Log("* ��ʼ��������");//��־

            audio.Play();
        }
        audio.Play();//��ʼ����
    }
}

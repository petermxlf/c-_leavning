using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiotest : MonoBehaviour
{
    public AudioClip audiosuccess;//��Ƶ����
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource audiosourse = GetComponent<AudioSource>();//��ȡ��Ƶ
            audiosourse.PlayOneShot(audiosuccess);//������Ƶ
        }
        
    }
}

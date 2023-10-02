using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicbox : MonoBehaviour
{
    public AudioClip[] songs;//��Ƶ����
    // Start is called before the first frame update
    void Start()
    {
        if (songs == null||songs.Length==0)
        {
            Debug.Log("* ���ڼ�����м����Դ");
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
        //�������
        int index = Random.Range(0, songs.Length);//�ӵ�����������������ȡһ��
        AudioClip clip = this.songs[index];
        AudioSource ac = GetComponent<AudioSource>();
        ac.clip = this.songs[index];
        ac.Play();
        Debug.Log("* ���ţ�" + clip.name);
    }
}

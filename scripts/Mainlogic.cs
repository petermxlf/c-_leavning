using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�������
//public ����� ������;
//�����ؽű�������ȫ���߼�
public class Mainlogic : MonoBehaviour
{
    //public GameObject bgmNode;
    public AudioSource bgm;//ֱ�ӵ������
    public GameObject moveNode;//���ýڵ�
    //public Movelogic mov;
    void Awake()
    {
        Application.targetFrameRate = 60;//֡��
        //AudioSource audio = bgmNode.GetComponent<AudioSource>();
        //audio.Play();

    }
    // Start is called before the first frame update
    void Start()
    {
        bgm.Play();
    }

    // Update is called once per frame
    void Update()
    {
        //������һ���ڵ��µ�AudioSource���
        if (Input.GetMouseButtonDown(0))
        {
            //Dowork();
            //��Ŀ�귢��һ����Ϣ
            Debug.Log("** ����һ����Ϣ��DoRotate");
            moveNode.SendMessage("DoRotate");//��Ϣ����,����
        }

    }
    void Dowork()
    {
        //Movelogic mov = moveNode.GetComponent<Movelogic>();//���ʽű����
        //mov.Speed = 180;
        //mov.Speed = 180;
    }
}

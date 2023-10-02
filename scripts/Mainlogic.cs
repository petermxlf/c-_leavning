using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//调用组件
//public 组件名 变量名;
//在主控脚本中设置全局逻辑
public class Mainlogic : MonoBehaviour
{
    //public GameObject bgmNode;
    public AudioSource bgm;//直接调用组件
    public GameObject moveNode;//引用节点
    //public Movelogic mov;
    void Awake()
    {
        Application.targetFrameRate = 60;//帧率
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
        //访问另一个节点下的AudioSource组件
        if (Input.GetMouseButtonDown(0))
        {
            //Dowork();
            //向目标发送一个消息
            Debug.Log("** 发送一个消息：DoRotate");
            moveNode.SendMessage("DoRotate");//消息调用,无用
        }

    }
    void Dowork()
    {
        //Movelogic mov = moveNode.GetComponent<Movelogic>();//访问脚本组件
        //mov.Speed = 180;
        //mov.Speed = 180;
    }
}

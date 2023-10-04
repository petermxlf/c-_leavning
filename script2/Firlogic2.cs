using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firlogic2 : MonoBehaviour
{
    //创建了对预制体的引用
    public GameObject bulletprefab;//节点类型变量
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Testfire();
        }
    }
    private void Testfire()
    {
        Debug.Log("* 创建子弹的实例 . .");
        //预制体实例化，并创建新的节点
        GameObject node=Object.Instantiate(bulletprefab, null);//将新创建的实例放在null下(根目录下)
        node.transform.position = Vector3.zero;//把节点放在世界中心
        node.transform.localEulerAngles = Vector3.zero;
    }
}

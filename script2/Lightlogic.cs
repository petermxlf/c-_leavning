using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightlogic : MonoBehaviour
{
    [Tooltip("ºì¡¢ÂÌ¡¢»Æ°´Ë³ÐòÖ¸¶¨")]
    public Material[] color;
    int c_index = 0;//ºìµÆ¿ªÊ¼
    // Start is called before the first frame update
    void Start()
    {
        Colors();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void Colors()
    {
        Material colors = this.color[c_index];
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = colors;
        Debug.Log("* change-> " + c_index + ". time=" + Time.time);
        if (c_index == 0)
        {
            Invoke("Colors", 4);//ºì-ÂÌ
        } else if (c_index == 1)
        {
            Invoke("Colors", 4);//ÂÌ-»Æ
        }
        else if (c_index == 2)
        {
            Invoke("Colors", 1);//»Æ-ºì
        }
        c_index++;
        if (c_index >= 3) c_index = 0;
    }
}

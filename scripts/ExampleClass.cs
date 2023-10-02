using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    string message;
    // Update is called once per frame
    void Update()
    {
        /*var input = Input.mousePosition;*/
        var input = Input.GetMouseButton(0);//读取鼠标左键，按下返回true
        message = input.ToString();
    }
    void OnGUI()
    {
        GUILayout.TextArea(message,200);
    }
}

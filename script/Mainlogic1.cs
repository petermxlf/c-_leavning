using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mainlogic1 : MonoBehaviour
{
    public Rotatelogic1 rotateLogic;
    public Flylogic flylogic;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rotateLogic.DoRotate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            flylogic.Fly();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            flylogic.Land();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumylogic2 : MonoBehaviour
{
    [Tooltip("µ–»À‘§÷∆ÃÂ")]
    public GameObject enumy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("testenumy", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void testenumy()
    {
        GameObject node = Instantiate(enumy, this.transform);
        node.transform.position = this.transform.position;
        float dx = Random.Range(-90, 90);
        node.transform.Translate(dx, 0, 0, Space.Self);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearingText : MonoBehaviour
{
    public GameObject textObj;
    float TmStart;
    float TmLen = 5f;


    // Start is called before the first frame update
    void Start()
    {
        TmStart = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>TmStart + TmLen)
        {
            textObj.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    // Start is called before the first frame update

    Text information;
    public float time = 5;

    void Start()
    {
        Destroy(gameObject, time);
        information = gameObject.GetComponent<Text>();
        information.text = "Each of those bubbles repersent 7500 tons of CO2, if a full day is 20 seconds long";
    }

    // Update is called once per frame
    void Update()
    {
        information.text = "Each of those bubbles repersent 7500 tons of CO2, if a full day is 20 seconds long";
    }
}

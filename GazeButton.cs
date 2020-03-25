using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeButton : MonoBehaviour
{

	public Image ButtonImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Blue()
    {
		ButtonImage.color = Color.blue;

	}

    public void Red()
	{
        ButtonImage.color = Color.red;
	}
}

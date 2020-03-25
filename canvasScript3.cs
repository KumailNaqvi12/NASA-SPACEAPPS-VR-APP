using UnityEngine;
using UnityEngine.UI;
public class canvasScript3 : MonoBehaviour
{
	public Text canvasText1;
	void Start()
	{
		Invoke("DisableText", 90f);//invoke after 5 seconds
	}
	void DisableText()
	{
		canvasText1.enabled = false;
	}
}
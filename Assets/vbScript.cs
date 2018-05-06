using System.Collections;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{
	private GameObject vbButtonObject;
	public GameObject vbmoon;


	void Start () {
		vbButtonObject = GameObject.Find("vbmoon");
		vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		vbmoon = GameObject.Find("vbmoon");
		
	}
	
	// Update is called once per frame
	public void OnButtonPressed (VirtualButtonBehaviour vb) 
	{
		Debug.Log("Play");
		vbmoon.GetComponent<AudioSource>().Play();
		
	}
	
	public void OnButtonReleased (VirtualButtonBehaviour vb)
	{
		Debug.Log("Stop");
		vbmoon.GetComponent<AudioSource>().Stop();
	}
}

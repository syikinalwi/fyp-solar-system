using System.Collections;
using UnityEngine;
using Vuforia;

public class vbScript1 : MonoBehaviour, IVirtualButtonEventHandler
{
	private GameObject vbButtonObject;
	public GameObject vbmush;


	void Start () {
		vbButtonObject = GameObject.Find("vbmush");
		vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		vbmush = GameObject.Find("vbmush");
		
	}
	
	// Update is called once per frame
	public void OnButtonPressed (VirtualButtonBehaviour vb) 
	{
		Debug.Log("Play");
		vbmush.GetComponent<AudioSource>().Play();
		
	}
	
	public void OnButtonReleased (VirtualButtonBehaviour vb)
	{
		Debug.Log("Stop");
		vbmush.GetComponent<AudioSource>().Stop();
	}
}

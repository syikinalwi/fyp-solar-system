using System.Collections;
using UnityEngine;
using Vuforia;

public class vbScript1 : MonoBehaviour, IVirtualButtonEventHandler
{
	private GameObject vbButtonObject;
	public GameObject Play;


	void Start () {
		vbButtonObject = GameObject.Find("Play");
		vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		Play = GameObject.Find("Play");
		
	}
	
	// Update is called once per frame
	public void OnButtonPressed (VirtualButtonBehaviour vb) 
	{
		Debug.Log("Play");
		Play.GetComponent<AudioSource>().Play();
		
	}
	
	public void OnButtonReleased (VirtualButtonBehaviour vb)
	{
		Debug.Log("Stop");
		Play.GetComponent<AudioSource>().Stop();
	}
}

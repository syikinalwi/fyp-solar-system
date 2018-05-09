using System.Collections;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour, IVirtualButtonEventHandler
{
	private GameObject vbButtonObject;
	public GameObject vbmoon; 
	//public Animator moon;


	void Start () {
		vbButtonObject = GameObject.Find("vbmoon");
		vbButtonObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		vbmoon = GameObject.Find("vbmoon");
		//moon.GetComponent<Animator>().RegisterEventHandler(this);
		
	}
	
	// Update is called once per frame
	public void OnButtonPressed (VirtualButtonBehaviour vb) 
	{
		Debug.Log("moon");
		//moon.Play("moon");
		vbmoon.GetComponent<AudioSource>().Play();
		//moon.GetComponent<Animation>().Play();
		
	}
	
	public void OnButtonReleased (VirtualButtonBehaviour vb)
	{
		Debug.Log("Stop");
		//moon.Play("none");
		vbmoon.GetComponent<AudioSource>().Stop();
	}
}

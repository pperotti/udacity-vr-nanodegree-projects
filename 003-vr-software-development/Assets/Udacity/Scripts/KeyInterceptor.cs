using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInterceptor : MonoBehaviour 
{
	public GameObject key;

	public void FixedUpdate()
	{
		//Vector3 fwd = transform.TransformDirection (Vector3.forward);
		Vector3 fwd = key.transform.forward;

		if(Physics.Raycast(transform.position, fwd, 10)) 
		{
			Debug.Log("Key Detected!");
		}
	}
}
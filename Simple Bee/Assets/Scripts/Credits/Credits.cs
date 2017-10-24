using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour 
{
	public int speed = 1;

	void Update () 
	{
		this.transform.Translate(Vector3.up * Time.deltaTime * speed);
	}
}

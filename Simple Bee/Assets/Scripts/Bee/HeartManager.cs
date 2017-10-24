using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManager : MonoBehaviour {

    public GameObject[] hearts;

	public void ShowHeart (int index) {
        hearts[index].SetActive(true);
	}
	
	public void ShowAllHearts () {
		foreach (GameObject go in hearts)
        {
            go.SetActive(true);
        }
	}

    public void HideHeart(int index)
    {
        hearts[index].SetActive(false);
    }

    public void HideAllHearts()
    {
        foreach (GameObject go in hearts)
        {
            go.SetActive(false);
        }
    }
}

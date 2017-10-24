using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWord : MonoBehaviour {

    private ArrayList words = new ArrayList();

    private void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            words.Add(i);
        }
    }

    public int ChoseRandWord ()
    {
        System.Random rand = new System.Random();
        int rNum = -1;
        do
        {
            rNum = rand.Next(0, 10);

        } while(!words.Contains(rNum));
        words.Remove(rNum);
        return rNum;
	}

    public void RemainingWords()
    {
        string temp = "";
        for (int i = 0; i < 10; i++)
        {
            temp += "[";
            if (words.Contains(i))
                temp += i;
            else
                temp += "x";
            temp += "]";
        }
        Debug.Log(temp);
    }
}

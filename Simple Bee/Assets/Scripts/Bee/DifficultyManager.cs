using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DifficultyManager : MonoBehaviour {

    private int difficulty;
    private int hearts;
    public Flowchart fc;

    private void Start() {
        difficulty = GetPlayerPrefDifficulty();
        hearts = GetPlayerPrefHearts();
    }

    public void SetGameDifficulty() {
        fc.SetIntegerVariable("difficulty", difficulty);
    }

    public void SetGameHearts()
    {
        fc.SetIntegerVariable("hearts", hearts);
    }

    public void SetPlayerPrefDifficulty(int val) {
        SetPlayerPref("diff", val);
    }

    public void SetPlayerPrefHearts(int val) {
        SetPlayerPref("hrt", val);
    }

    public int GetPlayerPrefDifficulty() {
        return GetPlayerPref("diff");
    }

    public int GetPlayerPrefHearts()
    {
        return GetPlayerPref("hrt");
    }

    public string GetDifficultyString() {
        return difficulty + "";
    }

    void SetPlayerPref (string ppName, int ppVal) {
        PlayerPrefs.SetInt(ppName, ppVal);
    }
	
	int GetPlayerPref (string ppName) {
		return PlayerPrefs.GetInt(ppName, 3);
	}

}

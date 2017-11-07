using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Analytics.Experimental;

public class AnalyticsController : MonoBehaviour
{

    public string levelName;

    // Use this for initialization
    void Start()
    {
        AnalyticsEvent.LevelStart(levelName);
        Debug.Log("Analytics Event Track: level start (" + levelName + ")");
    }

    public void EndLevel()
    {
        AnalyticsEvent.LevelComplete(levelName);
        Debug.Log("Analytics Event Track: level end (" + levelName + ")");
    }

    public void QuestionStart(string questionName)
    {
        AnalyticsEvent.Custom("QuestionStart | " + questionName);
        Debug.Log("Analytics Event Track: question start (" + questionName + ")");
    }

    public void QuestionEnd(string questionName)
    {
        AnalyticsEvent.Custom("QuestionEnd | " + questionName);
        Debug.Log("Analytics Event Track: question end (" + questionName + ")");
    }

    public void DialougeStart()
    {
        AnalyticsEvent.Custom("DialougeStart");
        Debug.Log("Analytics Event Track: dialouge start");
    }

    public void DialougeEnd()
    {
        AnalyticsEvent.Custom("DialougeEnd");
        Debug.Log("Analytics Event Track: dialouge end");
    }

    public void BeeWin()
    {
        AnalyticsEvent.Custom("BeeWin");
        Debug.Log("Analytics Event Track: Bee win");
    }

    public void BeeLose()
    {
        AnalyticsEvent.Custom("BeeLose");
        Debug.Log("Analytics Event Track: Bee lose");
    }
}

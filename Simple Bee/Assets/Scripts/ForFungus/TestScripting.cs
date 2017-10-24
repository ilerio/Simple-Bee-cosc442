using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TestScripting : MonoBehaviour {

    public Flowchart flowchart;

    private void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Exited");
        flowchart.SendFungusMessage("exit");
    }
}

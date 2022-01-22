using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEvent : MonoBehaviour
{

    public GameObject DebugUI;

    // Start is called before the first frame update
    void Start()
    {
        //DebugUI.GetComponent<CanvasDebug>().Log("Test");
        //DebugUI.GetComponent<CanvasDebug>().Log("Test 2");
        CanvasDebug.Log("Test");
        CanvasDebug.Log("Test2");
    }
}

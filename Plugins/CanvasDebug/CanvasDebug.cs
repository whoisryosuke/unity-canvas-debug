using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDebug : MonoBehaviour
{

    static public void Log(string message)
    {
        GameObject LogList = GameObject.Find("Debug UI/Scroll View/Viewport/Content/LogList");
        if (LogList == null)
        {
            Debug.Log("Could not find LogList in the scene. Please add CanvasUI prefab to scene.");
            return;
        }
        // Create new log item and make it a child of log list
        GameObject childObject = Instantiate(Resources.Load<GameObject>("Debug/LogItem"));
        Debug.Log("Creating child");
        Debug.Log(childObject);
        if(childObject == null)
        {
            Debug.Log("Could not find LogItem prefab in Resources folder.");
            return;
        }
        Debug.Log(LogList.transform);
        childObject.transform.parent = LogList.transform;
        //childObject.transform.SetParent(LogList.transform, false);

        // Set it as the first item (top of log)
        childObject.transform.SetAsFirstSibling();

        // Update text of new log item
        Text logText = childObject.GetComponent<Text>();
        logText.text = message;
    }
}

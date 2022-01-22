using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasDebug : MonoBehaviour
{

    public GameObject LogList;
    public GameObject LogItem;

    public void Log(string message)
    {
        // Create new log item and make it a child of log list
        GameObject childObject = Instantiate(LogItem);
        //childObject.transform.parent = LogList.transform;
        childObject.transform.SetParent(LogList.transform, false);

        // Set it as the first item (top of log)
        childObject.transform.SetAsFirstSibling();

        // Update text of new log item
        Text logText = childObject.GetComponent<Text>();
        logText.text = message;
    }
}

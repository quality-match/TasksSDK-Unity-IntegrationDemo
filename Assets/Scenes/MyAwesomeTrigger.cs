using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAwesomeTrigger : MonoBehaviour
{
    private bool _isTasksSdkWebviewActive;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !_isTasksSdkWebviewActive)
        {
            _isTasksSdkWebviewActive = true;
            QualityMatch.Tasks.Sdk.ShowTask((status, result) => {
                _isTasksSdkWebviewActive = false;
                Debug.Log(string.Format("OnTaskCompleted: [{0}] {1}", status, JsonUtility.ToJson(result)));
            });
        }
    }
}
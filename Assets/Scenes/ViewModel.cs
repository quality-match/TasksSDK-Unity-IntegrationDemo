using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewModel : MonoBehaviour
{
    public void Load_Task_UI()
    {
        QualityMatch.Tasks.Sdk.ShowTask((status, result) => {
            Debug.Log(string.Format("OnTaskCompleted: [{0}] {1}", status, JsonUtility.ToJson(result)));
        });
    }
}

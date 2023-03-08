using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class SphereController : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void LogString(string str);

    private void Start()
    {
        //SetHeight(3);
        Application.runInBackground = true;
    }

    public void SetHeight( float height )
    {
        string str = System.String.Format("SetHeight called with height {0}", height);
        LogString(str);
        Debug.Log(System.String.Format("Debug.Log: {0}", str));
        Vector3 pos = transform.position;
        pos.y = height;
        transform.position = pos;
    }
}

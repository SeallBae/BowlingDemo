using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Camera mcamera;
    private static float x_position = 0f;
    private static float y_position = 2.5f;
    private static float z_position = -4f;

    // Start is called before the first frame update
    void Start()
    {  
        mcamera = GetComponent<Camera>();
        // mcamera.transform.rotation = new Quaternion(0, x_rotation, 0, 0);
        Debug.Log(mcamera.transform.position);
    }
    // Update is called once per frame
    void Update()
    {
        if (score.trialno <=3 && (monitor.fallcount == 10) )
        {
            mcamera.transform.position = new Vector3(x_position,y_position,z_position - (score.level-1));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    movement m;
    void Start(){
        m = GameObject.FindGameObjectWithTag("Ball").GetComponent<movement>();
    }
    public void OnClick(){
        Debug.Log("Reach button reset");
        m.reset();
    }
}

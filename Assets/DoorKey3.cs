using UnityEngine;
using System.Collections;
 
public class DoorKey3 : MonoBehaviour {
 
    public bool inTrigger;
 
    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
 
    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }
 
    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                DoorScript3.doorKey = true;
                Destroy(this.gameObject);
            }
        }
    }
 
    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Press T to take key");
        }
    }
}
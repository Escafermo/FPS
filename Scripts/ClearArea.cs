using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {
    
    public float timeSinceLastTrigger = 0f;

    private bool foundClearArea = false;

    void OnTriggerStay(Collider collider)
    {
            timeSinceLastTrigger = 0f;
    }
    
	void Update () {
        
        timeSinceLastTrigger += Time.deltaTime;
        
        // When time since last tree|zombie trigger > 5 AND startup > 10
        if (timeSinceLastTrigger > 5f && Time.realtimeSinceStartup > 10f && !foundClearArea)
        {
            SendMessageUpwards("OnFindClearArea");
            foundClearArea = true;
            
            Debug.Log("Found clear are script");
        }
    }
}

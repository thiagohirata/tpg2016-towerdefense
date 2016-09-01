using UnityEngine;
using UnityEditor;
using System.Collections;

public class DestroyOnGoalBehaviour : MonoBehaviour {
    
    public int goalLayer;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == goalLayer)
        {
            Destroy(this.gameObject);
        }
    }
    
}

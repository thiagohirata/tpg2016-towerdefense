using UnityEngine;
using System.Collections;

public class LookAtBehaviour : MonoBehaviour {
    public Transform target;

    // Update is called once per frame
    void Update() {
        if (target != null)
        {
            this.transform.LookAt(target);
        }
    }
}

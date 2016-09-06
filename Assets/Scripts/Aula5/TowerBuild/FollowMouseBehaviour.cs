using UnityEngine;
using System.Collections;

public class FollowMouseBehaviour : MonoBehaviour {
    public int validLayer;
    public int maxRaycastDistance = 100;
    
    void Update()
    {

        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        int layerMask = 1 << validLayer;

        if (Physics.Raycast(ray, out hit, maxRaycastDistance, layerMask))
        {
            this.transform.position = hit.point;
        }
    }
}

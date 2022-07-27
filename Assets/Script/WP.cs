using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WP:MonoBehaviour
{
    public List<GameObject> neibors;
    private void OnDrawGizmos()
    {
        if (neibors!=null&&neibors.Count>0) 
        {
            foreach (GameObject g in neibors) 
            {
                Gizmos.color = Color.green;
                Gizmos.DrawLine(this.transform.position,g.transform.position);
            }
        }
    }
}
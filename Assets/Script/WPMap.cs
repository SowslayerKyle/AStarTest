using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WPMap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] points = GameObject.FindGameObjectsWithTag("WP");
        StreamWriter sw = new StreamWriter("Assets/point map.txt",false);
        string s = "";
        for (int i=0; i<points.Length;i++)
        {
            s = "";
            s += points[i].name;
            WP wp = points[i].GetComponent<WP>();
            s += " ";
            s += wp.neibors.Count;
            s += "";
            for (int j=0;j<wp.neibors.Count;j++)
            {
                s += wp.neibors[j].name;
                s += " ";
            }
            sw.WriteLine(s);
        }
        sw.Close();
    }
}

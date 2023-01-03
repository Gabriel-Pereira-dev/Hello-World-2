using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform reference;
    public Vector2 frequence;
    public Vector2 distance;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var sin = Mathf.Sin(Time.time * frequence.x) * distance.x;
        var cos = Mathf.Cos(Time.time * frequence.y) * distance.y;
        transform.position= reference.position +new Vector3(sin,0,cos);
        // Debug.Log("myNumber is "+ myNumber+ " with Time: "+Time.time);
    
    }
}

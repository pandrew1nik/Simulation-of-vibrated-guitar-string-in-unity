using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinusoidal : MonoBehaviour
{
    private float t = 0;
    public float frequency = 1000f;
    public float magnitude = 0.5f;
    public int num = 50;
    Vector3 pos;
    public string buttonname = "Space";
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if(Input.GetKey(KeyCode.Space))
        // {
        //     transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
        // }
        // else if(!Input.GetKey(KeyCode.Space))
        // {
        //     pos = new Vector3(0, 0, 0);
        // }
        if(Input.GetKey(KeyCode.Space)) Wave();
    }

    public void Wave()
    {
        transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;

        // for(int i = 0; i < num; i++)
        // {
        //     transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
        // }
        // pos = new Vector3(0, 0, 0);
    }
}

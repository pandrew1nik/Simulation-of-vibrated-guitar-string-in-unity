using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waving_5 : MonoBehaviour
{
    public float frequency = 1000f;
    public float magnitude = 0.2f;
    public Vector3 pos;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKey(KeyCode.Space)) Wave();
    //     else if(!Input.GetKey(KeyCode.Space)) transform.position = pos + new Vector3(0, 0, 0);
    // }

    public void Wave()
    {
        transform.position = pos + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
        source.Play();
        StartCoroutine(Mute());
    }

    public IEnumerator Mute()
    {
        source.mute = true;
        yield return new WaitForSeconds(0.3f);
        source.mute = false;
    }
}

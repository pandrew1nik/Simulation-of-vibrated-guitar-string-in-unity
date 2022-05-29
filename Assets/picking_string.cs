using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picking_string : MonoBehaviour
{
    Vector3 pos;
    private Vector2 raycastPosition;
    private RaycastHit2D hit;
    public waving_1 w1;
    public waving_2 w2;
    public waving_3 w3;
    public waving_4 w4;
    public waving_5 w5;
    public waving_6 w6;

    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MouseInput();
    }
    void FixedUpdate()
    {
        w5.transform.position = w5.pos + new Vector3(0, 0, 0);
    }

    public void MouseInput()
    {
        if(Input.GetMouseButton(0))
        {
            raycastPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(raycastPosition, Vector2.zero);


            if(hit.collider.name == "string_g_6")
            {
                var k = 0;
                do
                {
                    k++;
                    w6.Wave();
                } while (k < 10);
                Debug.Log(hit.collider.gameObject.name);
                Debug.Log(k);
                
            }
            
            if(hit.collider.name == "string_g_5")
            {
                var k = 0;
                do
                {
                    k++;
                    w5.Wave();
                } while (k < 100);
                Debug.Log(hit.collider.gameObject.name);
            }

            
            if(hit.collider.name == "string_g_4")
            {
                var k = 0;
                do
                {
                    k++;
                    w4.Wave();
                } while (k < 100);
                Debug.Log(hit.collider.gameObject.name);
            }
            
            if(hit.collider.name == "string_g_3")
            {
                var k = 0;
                do
                {
                    k++;
                    w3.Wave();
                } while (k < 100);
                Debug.Log(hit.collider.gameObject.name);
            }            
            
            if(hit.collider.name == "string_g_2") 
            {
                var k = 0;
                do
                {
                    k++;
                    w2.Wave();
                } while (k < 100);
                Debug.Log(hit.collider.gameObject.name);
            }
            
            if(hit.collider.name == "string_g_1")
            {
                var k = 0;
                do
                {
                    k++;
                    w1.Wave();
                } while (k < 100);
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
}

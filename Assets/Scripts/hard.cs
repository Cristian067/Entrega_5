using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class hard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.y >= -13)
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 5);
        }

        if(transform.position.y <= -13)
        {
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 5);
        }
        

        
    }
}

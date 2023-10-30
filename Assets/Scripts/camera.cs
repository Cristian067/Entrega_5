using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    [SerializeField] private GameObject camara;

    [SerializeField] private Vector3 offset = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        camara.transform.position = transform.position + offset;
        camara.transform.rotation = transform.rotation;
        
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{

    public GameObject player;

    [SerializeField] private Vector3 offset = new Vector3(13,0,0);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     

        transform.position = player.transform.position + offset;
        

    }
}

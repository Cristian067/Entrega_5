using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_prop : MonoBehaviour
{

    //public GameObject player;

    //private int pSpeed = player.speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime * (15 * 2));
        
    }
}

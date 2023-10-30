using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player_movement : MonoBehaviour
{

    [SerializeField] private int Speed = 15;
    [SerializeField] private int VSpeed = 15;



    //[SerializeField]

    private float horizontalInput;
    private float verticalInput;

    //private Vector3 goal = new Vector3(transform.position.x,transform.position.y, 250);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        transform.Rotate(new Vector3(-1,0,0) * verticalInput * VSpeed * Time.deltaTime);


        if (transform.position.z >= 250)
        {
            transform.position = new Vector3(0,0,0);
            transform.rotation = Quaternion.identity;
            Debug.Log("Win");
        }



    }
}

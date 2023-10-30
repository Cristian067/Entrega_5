using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player_2 : MonoBehaviour
{

    public GameObject player;

    [SerializeField] private Vector3 offset = new Vector3(13,0,0);
    [SerializeField] private Vector3 rot = new Vector3(13, 0, 0);


    public Transform cameraTransform;
    
    public float distanceFromCamera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Vector3 resultingPosition = cameraTransform.position + cameraTransform.forward + cameraTransform.rotation * distanceFromCamera;
        
        //transform.position = resultingPosition;
        
        transform.LookAt(player.transform);

        
        transform.position = player.transform.position + offset;
        //transform.rotation = player.transform.rotation;


    }
}

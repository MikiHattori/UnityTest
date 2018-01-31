using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField]
    GameObject cube;

    // Use this for initialization
    void Start()
    {
        //GetComponent<Rigidbody>().velocity = transform.right;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(cube.transform);
        if (Vector3.Distance(transform.position, cube.transform.position) > 10)
        {
            transform.position += transform.forward * 0.5f;
        }
        else
        {
            transform.position += transform.right * 0.1f;
        }


    }
}

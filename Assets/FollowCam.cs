using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FollowCam : MonoBehaviour
{
    public GameObject cam;
    float diffX;
    float diffY;
    float diffZ;
    // Start is called before the first frame update
    void Start()
    {
        diffX = transform.position.x - cam.transform.position.x;
        diffY = cam.transform.position.y - transform.position.y;
        diffZ = transform.position.z - cam.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cam.transform.position.x-diffX,cam.transform.position.y-diffY,cam.transform.position.z+diffZ);
    }
}

using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour
{

    public Transform target;
    private Transform tr;
    // Use this for initialization
    void Start()
    {

        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        tr.position = new Vector3(target.position.x, target.position.y + 20.0f, target.position.z);
        tr.LookAt(target);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5;
    MeshRenderer renderer;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity=false;
        renderer.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>timeToWait) {
            renderer.enabled=true;
            rigidBody.useGravity = true;
            // Debug.Log("time passed " + Time.time);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Transform transform;
    // Start is called before the first frame update
    [SerializeField] float xAngle=0;
    [SerializeField] float yAngle=0;
    [SerializeField] float zAngle=0;
    void Start()
    {
        // transform=GetComponent<Transform>();
    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}

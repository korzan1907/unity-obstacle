using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Variables for the movement
    // [SerializeField]float xValue = 0;
    // [SerializeField
    float yValue = 0;
    [SerializeField]float moveSpeed = 10f;
    // [SerializeField]float zValue = 0;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions(){
        Debug.Log("Welcome to the game");
        Debug.Log("This game is for test purposes only");
        Debug.Log("Move your player with WASD or arrow keys!");
    }

    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,yValue,zValue);
    }
}

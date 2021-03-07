using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    float yValue = 0;
    [SerializeField] float moveSpeed = 10f;


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

    void PrintInstructions ()
        {
            Debug.Log("Welcome to the Game!");
            Debug.Log("Move your player with the ASDF or Arrow keys. Have fun while playing.");
            Debug.Log("Don't hit the walls. Good Luck!");

        }
    
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);

    }


}

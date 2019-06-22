using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody body;
    private Vector3 movementVector;
    private Vector3 currentVector;

    private ArrayList enemies = new ArrayList();

    private float resistance = -0.1f;

    private const float speed = 10;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        
        spawnEnemy(10,10,10);
    }

    void spawnEnemy(Vector3 position)
    {
        
    }
    void spawnEnemy(float x, float y, float z){spawnEnemy(new Vector3(x,y,z));}

    private int getNegPos(float num)
    {
        if (num > 0)
        {
            return 1;
        }
        return -1;
    }

    private void applyResistance()
    {
        
    }

    private void FixedUpdate()
    {
        currentVector = body.velocity;
        // movements are floats between -1 and 1
        float leftRightMovement = Input.GetAxis("Horizontal");
        float forwardbackwardMovement = Input.GetAxis("Vertical");
        float upDownMovement = 0.0f;
        
        movementVector = new Vector3(leftRightMovement,
            upDownMovement, 
            forwardbackwardMovement
        );
        
        body.AddForce(movementVector);
        
        applyResistance();
        
        Debug.Log(body.velocity);
    }
}

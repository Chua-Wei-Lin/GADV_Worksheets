using UnityEngine;

public class SpriitMover : MonoBehaviour
{
    private int moveSpeed = 3; 
    private float timeElapsed = 2.5f; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Implicit conversion (int → float)
        float totalMovement = moveSpeed + timeElapsed; 
        transform.position = new Vector3(totalMovement, 0, 0);

        int roundedSpeed = totalMovement;

	    // Explicit conversion (truncates decimal)
        //roundedSpeed = (int)totalMovement; 

    }
}

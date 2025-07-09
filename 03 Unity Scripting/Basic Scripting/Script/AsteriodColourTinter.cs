using UnityEngine;
using UnityEngine.InputSystem;

public class AsteriodColourTinter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Access the SpriteRenderer component
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if ((Input.GetKeyDown(KeyCode.Space)) && spriteRenderer.color != Color.blue)
        {
            // Change the color to blue
            spriteRenderer.color = Color.blue;
        } 
        else if ((Input.GetKeyDown(KeyCode.Space)) && spriteRenderer.color == Color.blue)
        {
            spriteRenderer.color = Color.white;
        }

    }
}

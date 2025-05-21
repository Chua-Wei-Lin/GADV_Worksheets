using UnityEngine;

public class VarExample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Inferred as a SpriteRenderer
        var sprite = GetComponent<SpriteRenderer>();

        //Inferred as Color
        var spriteColor = sprite.color;

        //Inferred as Vector2
        var spriteSize = sprite.bounds.size;

        Debug.Log("Sprite Color: " + spriteColor);
        Debug.Log("Sprite Size: " + spriteSize);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class SpriteScalar : MonoBehaviour
{   
    private Transform spriteTransform;
    private string scale = "2.0a";
    private float scales;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scales = float.Parse(scale);
        spriteTransform = GetComponent<Transform>();
        spriteTransform.localScale = new Vector3(scales, scales, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class DataTpyeDemo : MonoBehaviour
{
    private Transform spriteTransform;
    private string scale = "2.0";
    public Vector3(){}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        Debug.Log("Data Types Demo");
        string scale = float.Parse(scale)
        spriteTransform = GetComponent<Transform>();        
        spriteTransform.localScale = new Vector3(scale, scale, 1f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public class Explodable : MonoBehaviour
{
    public void Explode()
    {
        Debug.Log("Boom!");
        Destroy(gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public class Item : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GetComponent<Explodable>()?.Explode();
            }
        }
    }
}

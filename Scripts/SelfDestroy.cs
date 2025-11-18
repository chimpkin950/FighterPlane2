using UnityEngine;

public class Destoyer : MonoBehaviour
{
    public float destructionTime;
    void Start()
    {
        Destroy(gameObject, destructionTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{ 
    public float rotationSpeed = 50f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    // Makes prop rotate
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        
    }
}

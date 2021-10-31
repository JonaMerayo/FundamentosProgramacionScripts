using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public float rotationSpeed = 1f; //The speed of the pickUp rotation


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate pickUps over time, for effect
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime *rotationSpeed);
    }
}

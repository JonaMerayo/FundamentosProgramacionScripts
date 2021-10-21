using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carGainPower : MonoBehaviour
{
    private float power= 1f;
    private Slider powerBar;
    // Start is called before the first frame update
    void Start()
    {
        this.powerBar = GameObject.FindWithTag("PowerBar").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        // If the object that hit is pickup
        if (col.gameObject.tag == "PickUp")
        {
            // Calculate force of the collision 
            Vector3 force = col.impulse / Time.fixedDeltaTime;

            // Gain power
            power += force.magnitude / 250000;
            powerBar.value = power;
        }

    }
}

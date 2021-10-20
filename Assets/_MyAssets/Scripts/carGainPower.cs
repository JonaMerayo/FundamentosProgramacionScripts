using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carGainPower : MonoBehaviour
{
    public float power= 1f;
    public Slider powerBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        // Calculate force of the collision 
        Vector3 force = col.impulse / Time.fixedDeltaTime;

        // Gain power
        power += force.magnitude / 500000;
        powerBar.value = power;
    }
}

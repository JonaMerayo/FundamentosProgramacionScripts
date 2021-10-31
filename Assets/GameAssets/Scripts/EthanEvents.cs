using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthanEvents : MonoBehaviour
{
    public delegate void PickedCoin();
    public event PickedCoin OnPickCoin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            if (OnPickCoin != null)
                OnPickCoin(); //Activates delegated method
            //Debug.Log("ethan detected");
        }
    }

}

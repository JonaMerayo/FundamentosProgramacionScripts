using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barPowerRegistry : MonoBehaviour
{
    public Slider powerBar;
    //public power playerHealth;

    // Start is called before the first frame update
    private void Start()
    {
        //playerPower = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        powerBar = GetComponent<Slider>();
        //healthBar.maxValue = playerHealth.maxHealth;
        //healthBar.value = playerHealth.maxHealth;
        SetPower(10);
    }

    public void SetPower(int hp)
    {
        powerBar.value = hp;
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
}

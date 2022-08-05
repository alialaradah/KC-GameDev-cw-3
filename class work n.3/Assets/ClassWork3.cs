using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassWork3 : MonoBehaviour
{

    string HeroName = "Cloud";
    int HeroPower = 250;

    string VillainName = "Sephiroth";
    int VillainPower = 500;


    double PlayerSpeed = 1.5;


    // Start is called before the first frame update
    void Start()
    {

        if (HeroPower > VillainPower)
        {
            print(" The Hero is stronger ");
        }
        else if (HeroPower == VillainPower)
        {
            print(" They Are Equal ");
        }
        else
        {
            print(" The Villain is stronger ");
        }

        SetSpeed(2.5);




    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSpeed(double NewSpeed)
    {
        print(" old player speed is " + PlayerSpeed);
        PlayerSpeed = NewSpeed;
        print(" new player speed is " + PlayerSpeed);
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    new string name;
    Critter critter;
    

    //Builder
    public Player(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return name;
    }
}

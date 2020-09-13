using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill
{
    //Attributes
    protected float power;
    protected string name;
    protected int affinity;
    

    //Builder
    public Skill()
    {


    }

    public string getName()
    {
        return name;
    }

    public float getPower()
    {
        return power;
    }
}

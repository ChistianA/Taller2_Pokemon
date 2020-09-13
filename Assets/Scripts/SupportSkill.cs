using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportSkill : MonoBehaviour
{
    int power;
    new string name;

    public SupportSkill(string name)
    {
        this.name = name;
        power = 0;
    }

    public float AttackUp(Critter critter)
    {
        float attackUp = critter.getBaseAttack() * 0.2f;
        return attackUp;
    }

    public void DefenseUp(Critter critter)
    {
        float defenseUp = critter.getBaseDefense() * 0.2f;
        
    }

    public float SpeedDown(Critter critter)
    {
        float speedDown = critter.getBaseSpeed() * 0.3f;
        return speedDown;
    }
}

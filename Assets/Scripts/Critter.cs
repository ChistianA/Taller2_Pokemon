using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Critter : MonoBehaviour
{
    //Attributes
    string critterName;
    int affinity;
    float baseAttack;
    float baseDefense;
    float baseSpeed;
    float hp;
    Skill moveSet;
    string[] nameAffinity = { "Dark", "Light", "Fire", "Water", "Wind", "Earth"};

    

    //Builder
    public Critter(string name, int  affinity, float baseAttack, float baseDefense, float baseSpeed, float hp, Skill moveSet)
    {
        name = critterName;
        this.affinity = affinity;
        this.baseAttack = baseAttack;
        this.baseDefense = baseDefense;
        this.baseSpeed = baseSpeed;
        this.hp = hp;
        this.moveSet = moveSet;
    }
    //Ver como solucionar que solo se puedan tener entre 1 y 3 instancias de Skill
    
    public string getName()
    {
        return critterName;
    }
    public string[] getNameAffinity()
    {
        return nameAffinity;
    }

    public float getBaseAttack() 
    { 
        return baseAttack; 
    }
    public float getBaseDefense() 
    { 
        return baseDefense; 
    }

    public float getBaseSpeed()
    {
        return baseSpeed;
    }

    public int getAffinity()
    {
        return affinity;
    }

    public float getHp() 
    {
        return hp; 
    }

    public void setHp(float hp)
    {
        this.hp = hp;
    }

}

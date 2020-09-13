using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSkill : Skill
{
    float[,] affinityMatrix = { { 0.5f, 2, 1, 1, 1, 1 }, { 2, 0.5f, 1, 1, 1, 1 }, { 1, 1, 0.5f, 2, 1, 0 }, { 1, 1, 0.5f, 0.5f, 2, 1 }, { 1, 1, 1, 0.5f, 0.5f, 0.5f }, { 1, 1, 1, 1, 2, 0.5f } };

    public AttackSkill(string name, int power, int affinity)
    {
        this.name = name;
        this.power = power;
        this.affinity = affinity;
    }

    public float MatrixAffinity(Critter player, Critter enemy)
    {
        float multiplier = affinityMatrix[player.getAffinity(), enemy.getAffinity()];
        return multiplier;
    }

    public float[,] AffinityMatrix { get => affinityMatrix; set => affinityMatrix = value; }

    public float Attack(Critter player, Critter enemy, float power)
    {
        float damageValue = (player.getBaseAttack() + power) * MatrixAffinity(player, enemy);
        return damageValue;
    }
}

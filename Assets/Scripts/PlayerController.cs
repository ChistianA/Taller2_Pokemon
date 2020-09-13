using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Player player1;
    [SerializeField] string playerName; 
    [SerializeField] string nameCritter1; 
    [SerializeField] int affinity; 
    [SerializeField] float baseAttack; 
    [SerializeField] float baseDefense; 
    [SerializeField] float baseSpeed; 
    [SerializeField] float hp;
    Critter critter;
    AttackSkill moveset;

    // Start is called before the first frame update
    void Start()
    {
        player1 = new Player(playerName);
        moveset = new AttackSkill("Impactrueno",10,1);
        critter = new Critter(nameCritter1,affinity,baseAttack,baseDefense,baseSpeed,hp, moveset);
        List<Critter> critters = new List<Critter>(){critter};
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referee : MonoBehaviour
{
    public Player player1;
    public Player player2;
    public Critter critter1;
    public Critter critter2;
    public AttackSkill attackSkill;
    public AttackSkill attackSkill2;
    public AttackSkill attackSkill3;
    public SupportSkill supportSkill1;
    public SupportSkill supportSkill2;
    public SupportSkill supportSkill3;
    bool startGame;
    bool attack;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GetComponent<Player>();
        player2 = GetComponent<Player>();
        attackSkill = new AttackSkill("Hit",10,2);
        attackSkill2 = new AttackSkill("Smash",8,0);
        attackSkill3 = new AttackSkill("Special",8,0);
        supportSkill1 = new SupportSkill("AtkUp");
        supportSkill2 = new SupportSkill("DefenseUp");
        supportSkill3 = new SupportSkill("SpdDwn");

    }

    // Update is called once per frame
    void Update()
    {
        if(startGame){

        }
    }

    public void Attack(string attackSkillName){
        if(attackSkillName == "Hit"){
            attackSkill.Attack(critter1,critter2,attackSkill.getPower());
            Debug.Log(attackSkill.getName() + " " + critter2.getHp());
        }
        else if(attackSkillName == "Smash"){
            attackSkill2.Attack(critter1,critter2,attackSkill2.getPower());
            Debug.Log(attackSkill2.getName() + " " + critter2.getHp());
        }
        else if(attackSkillName == "Special"){
            attackSkill3.Attack(critter1,critter2,attackSkill3.getPower());
            Debug.Log(attackSkill3.getName() + " " + critter2.getHp());
        }
        
    }
    public void SupportSkill(){
        supportSkill1.AttackUp(critter1);
        Debug.Log(supportSkill1.AttackUp(critter1));
    }


}

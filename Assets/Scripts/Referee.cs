using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    bool attackBool = false;
    public Text hpText1;
    public Text hpText2;
    int rand;
    UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        hpText1.text = critter2.getHp().ToString() + " HP";
        hpText2.text = critter1.getHp().ToString() + " HP";
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
        if(attackBool == true){
            uiManager.Disable_Interface();
            EnemyAttack(1);
            
        }
        else{
            uiManager.Enable_Enterface();
        }
    }

    public void Attack(string attackSkillName){
        if(attackSkillName == "Hit"){
            attackSkill.Attack(critter1,critter2,attackSkill.getPower());
            hpText1.text = critter2.getHp().ToString() + " HP";
            attackBool = true;
        }
        else if(attackSkillName == "Smash"){
            attackSkill2.Attack(critter1,critter2,attackSkill2.getPower());
            hpText1.text = critter2.getHp().ToString() + " HP";
            attackBool = true;
        }
        else if(attackSkillName == "Special"){
            attackSkill3.Attack(critter1,critter2,attackSkill3.getPower());
            hpText1.text = critter2.getHp().ToString() + " HP";
            attackBool = true;
        }
    }
    public void EnemyAttack(int numAttack){
        if(numAttack == 0){
            attackSkill.Attack(critter2,critter1,attackSkill.getPower());
            hpText2.text = critter1.getHp().ToString() + " HP";
            attackBool = false;
        }
        else if(numAttack == 1){
            attackSkill2.Attack(critter2,critter1,attackSkill2.getPower());
            hpText2.text = critter1.getHp().ToString() + " HP";
            attackBool = false;
        }
        else if(numAttack == 2){
            attackSkill3.Attack(critter2,critter1,attackSkill3.getPower());
            hpText2.text = critter1.getHp().ToString() + " HP";
            attackBool = false;
        }
    }

    public void SupportSkill(){
        supportSkill1.AttackUp(critter1);
        Debug.Log(supportSkill1.AttackUp(critter1));
    }


}

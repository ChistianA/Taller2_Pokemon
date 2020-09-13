using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject attack_defenseButton;
    [SerializeField] GameObject attackSkills;
    [SerializeField] GameObject supportSkills;

    public void SetAttackSkills(){
        attack_defenseButton.SetActive(false);
        attackSkills.SetActive(true);
    } 

    public void SetSupportSkills(){
        attack_defenseButton.SetActive(false);
        supportSkills.SetActive(true);
    }

}

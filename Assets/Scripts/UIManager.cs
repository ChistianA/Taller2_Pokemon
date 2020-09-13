using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject attack_defenseButton;
    [SerializeField] GameObject attackSkills;
    [SerializeField] GameObject supportSkills;
    public GameObject interfacce;



    private void Start() {
        
    }

    public void SetAttackSkills(){
        attack_defenseButton.SetActive(false);
        attackSkills.SetActive(true);
    } 

    public void SetSupportSkills(){
        attack_defenseButton.SetActive(false);
        supportSkills.SetActive(true);
    }

    public void Disable_Interface()
    {
        interfacce.SetActive(false);
    }
    public void Enable_Enterface(){
        interfacce.SetActive(true);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [Header("Unit Info")]
    public string unitName;
    public string unitClass;
    public string unitDescription;
    public string passiveAbility;
    public string passiveAbilityDescription;
    public string specialAbility;
    public string specialAbilityDescription;    

    [Header("Unit Stats")]
    public int unitHealth;
    public int unitCurrentHealth;
    public int unitMinAttack;
    public int unitMaxAttack;
    public int unitSpeed;


    [Header("Battle Info")]
    [HideInInspector] public string attackTargets;
    [HideInInspector] public string specialAttackTargets;
    public bool movedThisRound = false;
    public bool isDead = false;
    private Animator animator;
    public bool IsMoved = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

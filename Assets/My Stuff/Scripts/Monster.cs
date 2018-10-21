using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("Vital Statistics")]
    [SerializeField] string type = "";
    [SerializeField] string[] subTypes;
    [SerializeField] int HitDice = 1;
    [SerializeField] int experiencePoints = 400;
    
    [Header("Creature Type Bonuses")]
    [SerializeField] int fortitudeBonus = 0;
    [SerializeField] int reflexBonus = 0;
    [SerializeField] int willpowerBonus = 0;
    [SerializeField] int baseAttackBonus = 0;

    private int fortitude;
    private int reflex;
    private int willpower;
    private int meleeAttack;
    private int rangedAttack;
    private int combatManeuverAttack;
    private int combatManeuverDefense;
    private int armorClass;

    Creature race;

    void Start ()
    {
        race = GetComponent<Creature> ();
        fortitude = fortitudeBonus + race.ConMod ();
        reflex = reflexBonus + race.DexMod ();
        willpower = willpowerBonus + race.WisMod ();
        meleeAttack = baseAttackBonus + race.StrMod ();
        rangedAttack = baseAttackBonus + race.DexMod ();
        combatManeuverAttack = baseAttackBonus + race.StrMod ();
        combatManeuverDefense = 10 + baseAttackBonus + race.StrMod () + race.DexMod ();
        armorClass = 10 + race.DexMod () + race.NatrualArmor () /*+ equipement.Armor () + equipment.Shield () */;
    }
}

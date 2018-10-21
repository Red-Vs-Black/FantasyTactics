using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    [Header("Misc. Stats")]
    [SerializeField] int maxHP = 10;
    [SerializeField] int speed = 30;
    [SerializeField] int naturalArmor = 0;

    [Header("Ability Scores")]
    [SerializeField] int strength = 10;
    [SerializeField] int dexterity = 10;
    [SerializeField] int constitution = 10;
    [SerializeField] int intelligence = 10;
    [SerializeField] int wisdom = 10;
    [SerializeField] int charisma = 10;
    

    //Ability Modifiers
    private int strMod;
    private int dexMod;
    private int conMod;
    private int intMod;
    private int wisMod;
    private int chaMod;
    private int curHP;
    private int gridSpeed;
    private int initiative;

    void Start ()
    {
        strMod = (int)Mathf.Floor ((strength-10)/2);
        dexMod = (int)Mathf.Floor ((dexterity-10)/2);
        conMod = (int)Mathf.Floor ((constitution-10)/2);
        intMod = (int)Mathf.Floor ((intelligence-10)/2);
        wisMod = (int)Mathf.Floor ((wisdom-10)/2);
        chaMod = (int)Mathf.Floor ((charisma-10)/2);
        curHP = maxHP;
        gridSpeed = speed/5;
        initiative = dexMod;
    }

    public int Strength () {return strength;}
    public int Dexterity () {return dexterity;}
    public int Constitution () {return constitution;}
    public int Intelligence () {return intelligence;}
    public int Wisdom () {return wisdom;}
    public int Charisma () {return charisma;}

    public int StrMod () {return strMod;}
    public int DexMod () {return dexMod;}
    public int ConMod () {return conMod;}
    public int IntMod () {return intMod;}
    public int WisMod () {return wisMod;}
    public int ChaMod () {return chaMod;}

    public int HP () {return curHP;}
    public void ModHP (int mod)
    {
        curHP += mod;
        
        if(curHP > maxHP)
        {
            curHP = maxHP;
        }
        else if (curHP <= 0 && curHP > -constitution)
        {
            //bleed out
        }
        else if (curHP <= -constitution)
        {
            //death
        }
    }
    public int Initiative () {return initiative;}
    public int NatrualArmor () {return naturalArmor;}
}

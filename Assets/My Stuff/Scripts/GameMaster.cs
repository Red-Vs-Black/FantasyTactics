using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	/*
	void CalculateHitChance()
	{
		get attacker;
	  	get defender;
	 	get toHitHUD;
	  	int rawToHit;
	
		if (melee)
		{
	 		rawToHit = defender.AC - attacker.meleeAttackBonus;
		}
	 	else if (ranged)
	 	{
	 		rawToHit = defender.AC - attacker.rangedAttackBonus;
	 	}
	 	
	 	if (defender.imobilized)
	 	{
	 		rawToHit -= defender.dodge;
	 	}
	 	
	 	if (magic)
	 	{
	 		rawToHit -= defender.armor;
	 	}
	 	
	 	int toHitChance = 20 - rawToHit;
		toHitHUD.text = "" + (toHitChance * 5) + "%";

		ResolveAttack(toHitChance);
	 }

	void CalculateEffectChance()
	{
		get attacker;
		get defender;
		get toHitHUD;
		int rawToHit;

		if (fortitude)
		{
			rawToHit = attacker.attack.DC - defender.fortitude;
		}
		if (reflex)
		{
			rawToHit = attacker.attack.DC - defender.reflex;
		}
		if (willpower)
		{
			rawToHit = attacker.attack.DC - defender.willpower;
		}

		int toHitChance = 20 - rawToHit;
		toHitHUD.text = (toHitChance * 5) + "%";
	}

	void ResolveAttack(int hitChance)
	{
		int hitRoll = Random.Range(1,21);

		if (hitRoll <= hitChance )
		{
			//Attack lands
			DealDamage();
		}
		else
		{
			//Attack missed
		}
	}

	void ResolveEffect(int hitChance)
	{
		int hitRoll = Random.Range(1,21);

		if (hitRoll <= hitChance )
		{
			//Attack lands
		}
		else
		{
			//Attack missed
		}
	}

	void DealDamage()
	{
		get attacker;
		get defender;

		defender.HP -= Random.Range(attacker.weapon.min, (attacker.weapon.max + 1));
	}
	*/
}

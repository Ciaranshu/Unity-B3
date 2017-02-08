using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyInfo {
	///////////////////////////////////////////////////////////
	//-----------------------Player--------------------------//
	//-------------------------------------------------------------------
	public const string PlayerTag = "Player";
	public const string weaponTag = "bullet";


	///////////////////////////////////////////////////////////
	//-----------------------BloodObj--------------------------//
	//-------------------------------------------------------------------
	public const string tag_BloodCore = "BloodCore";
	public const string tag_Blood = "Blood";


	///////////////////////////////////////////////////////////
	//------------------------BossBlood---------------------------//
	//-------------------------------------------------------------------


	///////////////////////////////////////////////////////////
	//------------------------Boss---------------------------//
	//-------------------------------------------------------------------Boss的人物标签
	public const string tag_BossModel = "BossModel";
	//-------------------------------------------------------------------Boss血量
	public static float f_BossTotalBlood = 100;
	public static float f_BossHurtedBloodDcr = 10;
	//-------------------------------------------------------------------Boss血条
	public const string tag_BloodValue = "BloodValue";
	public const string tag_BloodCylinderCore = "BloodCylinderCore";
	public const string tag_BloodCylinder = "BloodCylinder";
	public const string tag_BloodTextCore = "BloodTextCore";
	public const string tag_BloodTextFront = "BloodTextFront";
	public const string tag_BloodTextBack = "BloodTextBack";
	//-------------------------------------------------------------------Boss技能1
	public const string tag_BossAttack1Core = "Attack1FireCore";
	public const string tag_BossAttack1 = "Attack1Fire";
	public static float f_BossAttack1Start = 1.0f;
	public static float f_BossAttack1Stay = 5.0f;
	public static float f_BossAttack1Stop = 10.0f;
	//-------------------------------------------------------------------Boss技能2
	public const string tag_BossAttack2Core = "Attack2ChalkCore";
	public const string tag_BossAttack2 = "Attack2Chalk";
	public static float f_BossAttack2Start = 1.0f;
	public static float f_BossAttack2Stay = 3.0f;
	public static float f_BossAttack2MinDis = 4.0f;//攻击距离触发
	//-------------------------------------------------------------------Boss前进速度
	public static float f_BossSpeed = 0.01f;



	///////////////////////////////////////////////////////////
	//------------------------Guard---------------------------//
	public const string tag_Guard = "Guard";
	public const string tag_GuardModel = "GuardModel";
	public static float f_GuardTurnBackDis = 2.0f;

	///////////////////////////////////////////////////////////
	//------------------------Necromancer---------------------------//
	public const string tag_Necromancer = "Necromancer";
	public const string tag_NecromancerModel = "NecromancerModel";
	public const string tag_NecromancerAttackCore = "NecromancerAttackCore";
	public const string tag_NecromancerAttack = "NecromancerAttack";
	public static float f_NecromancerAttackStart = 0.0f;
	public static float f_NecromancerAttackStay = 4.0f;
	public static float f_NecromancerAttackStop = 6.0f;

	///////////////////////////////////////////////////////////
	//------------------------Ninja---------------------------//
	public const string tag_Ninja = "Ninja";
	public const string tag_NinjaModel = "NinjaModel";
	public static float f_NinjaMoveSpeed = 0.05f;
	public static float f_NinjaDesSelfTime = 4.0f;


	///////////////////////////////////////////////////////////
	//------------------------Trap---------------------------//
	public const string tag_Trap = "Trap";
	public const string tag_TrapModel = "TrapModel";
	public const string tag_TrapAttackCore = "TrapAttackCore";
	public const string tag_TrapAttack = "TrapAttack";


	public const string tag_TrapTrigger = "TrapTrigger";

}

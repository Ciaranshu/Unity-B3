using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TriggerBoss : Trigger {
	private MoveBoss ClassMoveBoss;private GameObject bossObj;
	private Transform bossModelTrns;

	private Transform bloodCylinderCoreTrns;
	private Transform bloodTextCoreTrns;

	// Use this for initialization
	protected override void Start () {
		bossModelTrns = transform.parent;//综合模型的Transform
		bossObj = bossModelTrns.parent.gameObject;
		ClassMoveBoss = bossObj.GetComponent<MoveBoss> ();//整体的GO

		Transform bloodValueTrns = bossModelTrns.FindChild (EnermyInfo.tag_BloodValue);
		bloodCylinderCoreTrns = bloodValueTrns.FindChild (EnermyInfo.tag_BloodCylinderCore);//xuetiao waike
		bloodTextCoreTrns = bloodValueTrns.FindChild (EnermyInfo.tag_BloodTextCore);//text shell
	}


	protected override void OnTriggerEnter(Collider coll){
		if(coll.tag == EnermyInfo.weaponTag){
			Debug.Log ("【Boss】被玩家攻击了！");

			//还没打败Boss
			if (ClassMoveBoss.setCurrentBlood ()) {
				//调整血条长度
				float currentBlood = ClassMoveBoss.getCurrentBlood () ;
				float totalBlood = EnermyInfo.f_BossTotalBlood;
				Vector3 temp = bloodCylinderCoreTrns.localScale;
				temp.x = (currentBlood / totalBlood);
				bloodCylinderCoreTrns.localScale = temp;
				//调整血条color
				if (temp.x > 0.4)
					bloodCylinderCoreTrns.FindChild (EnermyInfo.tag_BloodCylinder).GetComponent<MeshRenderer> ().material.color =
						Color.green;
				else
					bloodCylinderCoreTrns.FindChild (EnermyInfo.tag_BloodCylinder).GetComponent<MeshRenderer> ().material.color = 
						Color.red;
				//调整血条text
				string textTemp = currentBlood + "/" + totalBlood;
				bloodTextCoreTrns.FindChild (EnermyInfo.tag_BloodTextFront).GetComponent<Text> ().text = 
					textTemp;
				bloodTextCoreTrns.FindChild (EnermyInfo.tag_BloodTextBack).GetComponent<Text> ().text = 
					textTemp;
			} else {
				Debug.Log ("你打败【Boss】了！");
				Des ();
				//Invoke ("Des", Mathf.Max (EnermyInfo.f_BossAttack1Stay, EnermyInfo.f_BossAttack2Stay));
			}//end if else
		}//end if
	}//end the function


	protected override void Des(){
		GameObject blood = Resources.Load ("BloodCore")as GameObject;
		Destroy (bossModelTrns.gameObject);
		Instantiate (blood, bossObj.transform.position, Quaternion.identity);
	}

}

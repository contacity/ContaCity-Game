using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

namespace GlobalVars {


	#region public Enums

//**	public enum PrefabTypes { None, Player ,Bullet, Punchy , Rocket, UIMessage, Coin, SwitchStateEffect};

	//** public enum SFXtype { None, Coin };


	//** public enum MonstersType { None, Punch };

	//** public enum StateType { None, Healing, Moving, Running, Attacking };

	#endregion


	#region Public Delegates

//**	public delegate void Action ();

	//**	public delegate void MB (MonsterBrain mb);

	#endregion	


	public class Events : MonoBehaviour {


		#region Color Scene
		public delegate void OneColorEvent();
		public static event OneColorEvent ChangeToRed;

		public static void CallChangeToRed(){
			ChangeToRed ();
		}

		public delegate void TowColorEvent(Color col);
		public static event TowColorEvent ChangeToCol;

		public static void CallChangeToCol(Color col){
			ChangeToCol (col);
		}

		#endregion



		#region Rocket Scene

		#endregion



		#region TopDownShooter Scene


//		public delegate void Event();
//		public static event Event OnPlayerDeath, OnSceneLeave;

	//	public static void ActivateOnPlayerDeath(){
	//		if (OnPlayerDeath != null)
	//			OnPlayerDeath ();
	//		else
	//			Debug.LogError ("OnPlayerDeath is empty!");
	//	}
	//	public static void CallOnSceneLeave(){
	//		OnSceneLeave ();
	//	}



	//	public delegate void GameObjectEvent(GameObject player);
	//	public static event GameObjectEvent OnPlayerSpawn;

	//	public static void ActivateOnPlayerSpawn(GameObject player){
	//		OnPlayerSpawn (player);
	//	}
	//

		#endregion


	}


}



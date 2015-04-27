using UnityEngine;
using System.Collections;

public class BattleScript : MonoBehaviour {

	public enum BattleState{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}
	private BattleState currentState;
	// Use this for initialization
	void Start () {
		currentState = BattleState.START;
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (currentState);
		switch(currentState){
		case (BattleState.START):
			//SETUP 
			break;
		case (BattleState.PLAYERCHOICE):
			//Player Choice
			break;
		case (BattleState.ENEMYCHOICE):
			//Enemy turn 
			break;
		case (BattleState.LOSE):
			//Lost Battle
			break;
		case (BattleState.WIN):
			//Won Battle
			break;
		}
	}

	void OnGUI(){
		if(GUILayout.Button("NEXT STATE")){
			if(currentState == BattleState.START){
				currentState = BattleState.PLAYERCHOICE;
			}
			else if(currentState == BattleState.PLAYERCHOICE){
					currentState = BattleState.ENEMYCHOICE;
			}
			else if(currentState == BattleState.ENEMYCHOICE){
				currentState = BattleState.LOSE;
			}
			else if(currentState == BattleState.LOSE){
				currentState = BattleState.WIN;
			}
			else if(currentState == BattleState.WIN){
				currentState = BattleState.START;
			}
		}
	}
}
 
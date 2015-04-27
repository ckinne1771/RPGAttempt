using UnityEngine;
using System.Collections;

public class BattleScript : MonoBehaviour {
	public enum BattleState {
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private BattleState currentState = BattleState.START;

	void Update() {
		switch (currentState) {
		case BattleState.START:
			//SETUP
			break;
		case BattleState.PLAYERCHOICE:
			//Player Choice
			break;
		case BattleState.ENEMYCHOICE:
			//Enemy turn
			break;
		case BattleState.LOSE:
			//Lost Battle
			break;
		case BattleState.WIN:
			//Won Battle
			break;
		}
	}
}

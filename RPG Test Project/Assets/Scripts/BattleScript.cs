using UnityEngine;
using System.Collections;
using System;

public class BattleScript : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	private GameObject[] players;
//	private GameObject[] enemies;
	//private GameObject[] characters;

	public enum BattleState {
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private BattleState currentState = BattleState.START;

	void Start()
	{
		players = GameObject.FindGameObjectsWithTag("Character");
	//	enemies = GameObject.FindGameObjectsWithTag("Enemy");
		if(players[0]!= null)
		{

			player1 = players[0];
			Debug.Log("Picked Up Player");
		}
		else  
		{
			player1 = null;

		}
		if(players[1]!= null)
		{
			
			player2 = players[1];
			Debug.Log("Picked Up Player2");
		}
		else  
		{
			player2 = null;
			
		}
		if(players[2]!= null)
		{
			
			player3 = players[2];
			Debug.Log("Picked Up Player3");
		}
		else  
		{
			player3 = null;
			
		}
		if(players[3]!= null)
		{
			enemy1 = players[3];
		}
		else 
		{ 
			enemy1 = GameObject.Find ("Empty Enemy");
			
		}
		if(players[4]!= null)
		{
			enemy2 = players[4];
		}
		else if(players[4]== null)
		{ 
			enemy2 = GameObject.Find ("Empty Enemy");
			
		}
		if(players[5]!= null)
		{
			enemy3 = players[5];
		}
		else if(players[5]== null)
		{ 
			enemy3 = GameObject.Find ("Empty Enemy");
			
		}
		if(players[6]!= null)
		{
			enemy4 = players[6];
		}
		else if(players[6]== null)
		{ 
			enemy4 = GameObject.Find ("Empty Enemy");
			
		}
		if(players[7]!= null)
		{
			enemy5 = players[7];
		}
		else if(players[7]== null)
		{ 
			enemy4 = GameObject.Find ("Empty Enemy");
			
		}
	}

	private class sortCharacterStatsSpeed: IComparer
	{
		int IComparer.Compare(object a, object b){
			PartyMemberScript p1 = ((GameObject)a).GetComponent<PartyMemberScript>();
			PartyMemberScript p2 = ((GameObject)b).GetComponent<PartyMemberScript>();
			if (p1.speed < p2.speed)
				return 1;
			else if (p1.speed > p2.speed)
				return -1;
			else
				return 0;
		}
	}
	void Update() {
		switch (currentState) {
		case BattleState.START:
			//SETUP

		

			Array.Sort(players, (IComparer)new sortCharacterStatsSpeed());
			foreach (GameObject player in players)
			{
			Debug.Log (player.GetComponent<PartyMemberScript>().speed);
			}
			currentState = BattleState.PLAYERCHOICE;
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

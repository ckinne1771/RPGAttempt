using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class BattleScript : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public GameObject player3;
	public GameObject enemy1;
	public GameObject enemy2;
	public GameObject enemy3;
	public GameObject enemy4;
	public GameObject enemy5;
	private List<GameObject> players = new List<GameObject>();
	private List<GameObject> sortedPlayers = new List<GameObject>();
//	private GameObject[] enemies;
	//private GameObject[] characters;
	public static bool choiceMade = false;
	public enum BattleState {
		START,
		SORT,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN
	}

	private BattleState currentState = BattleState.START;

	void Start()
	{
		players.AddRange(GameObject.FindGameObjectsWithTag ("Character"));
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

	public void ChoiceForButton(){
		choiceMade = true;
	}

/*	private class sortCharacterStatsSpeed: IComparer
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
	}*/
	void Update() {
		switch (currentState) {
		case BattleState.START:
			//SETUP

			sortedPlayers = players.OrderByDescending(x=>x.GetComponent<PartyMemberScript>().speed).ToList();
			/*foreach (GameObject player in sortedPlayers)
			{
			Debug.Log (player.GetComponent<PartyMemberScript>().speed);
			}*/
			currentState = BattleState.SORT;

			break;
		case BattleState.SORT:
			if(sortedPlayers[0].GetComponent<PartyMemberScript>().isPlayer ==true)
			{
				currentState = BattleState.PLAYERCHOICE;
			}
			else
			{ 
				currentState = BattleState.ENEMYCHOICE;
			}
			break;
		case BattleState.PLAYERCHOICE:
			//Player Choice
			//Debug.Log ("Player");

			UIScript.buttonsActive = true;
			if(sortedPlayers[0].gameObject.name=="Party Member 1")
			{
				UIScript.TurnIndictator1GO.SetActive(true);
			}
			if(sortedPlayers[0].gameObject.name=="Party Member 2")
			{
				UIScript.TurnIndictator2GO.SetActive(true);
			}
			if(sortedPlayers[0].gameObject.name=="Party Member 3")
			{
				UIScript.TurnIndictator3GO.SetActive(true);
			}
			 
			if(choiceMade == true)
			{
				sortedPlayers.RemoveAt (0);
				choiceMade = false;
				UIScript.buttonsActive = false;
				currentState = BattleState.SORT;
				break;
			}

			//currentState = BattleState.ENEMYCHOICE;
			break;
		case BattleState.ENEMYCHOICE:
			//Enemy turn
			Debug.Log ("Enemy");
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

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScript : MonoBehaviour {

	public GameObject ActionBarGO;
	public GameObject FightButtonGO;
	public GameObject MagicButtonGO;
	public GameObject SkillButtonGO;
	public GameObject ItemButtonGO;
	public GameObject RunButtonGO;
	public static GameObject TurnIndictator1GO;
	public static GameObject TurnIndictator2GO;
	public static GameObject TurnIndictator3GO;

	Text ActionBarText;

	public static bool buttonsActive;
	// Use this for initialization
	void Start () {
		TurnIndictator1GO = GameObject.Find("Turn Indicator");
		TurnIndictator2GO = GameObject.Find("Turn Indicator 1");
		TurnIndictator3GO = GameObject.Find("Turn Indicator 2");
		///ActionBarText = ActionBarGO.GetComponent<Text>();
		buttonsActive=false;
	}
	
	// Update is called once per frame
	void Update () {
	 if(buttonsActive == false)
		{
			FightButtonGO.SetActive(false);
			MagicButtonGO.SetActive(false);
			SkillButtonGO.SetActive(false);
			ItemButtonGO.SetActive(false);
			RunButtonGO.SetActive(false);
			TurnIndictator1GO.SetActive (false);
			TurnIndictator2GO.SetActive (false);
			TurnIndictator3GO.SetActive (false);
		}
		if(buttonsActive == true)
		{
			Debug.Log ("Active");
			FightButtonGO.SetActive(true);
			MagicButtonGO.SetActive(true);
			SkillButtonGO.SetActive(true);
			ItemButtonGO.SetActive(true);
			RunButtonGO.SetActive(true);
		}
	}
}

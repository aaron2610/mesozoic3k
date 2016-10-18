using UnityEngine;
using System.Collections;

public class CharInfo : MonoBehaviour {

	public int factionID;
	[Header("Character Info")]
	[Header(FullCharName)]
	[Tooltip("Health value between 0 and 100.")]
	public int health = 0;
	public int maxHealth = 100;
	public string charNickName;
	public string charFrom;
	public float charStr;
	public float charStamina = 20 + clan_skill_bonus;
	public float charFootSpeed = Random.Range(.9, 1.2);
	public float charTotalDMG;

	string charDisplayName = charName + " of " + charFrom;

	// Use this for initialization
	void Start () {
		// Determine if there's a nickname
		
		maxHealth = Random.Range(80, 110);
		health = maxHealth;
		charTotalDMG = (charStr / 10 ) + weaponDMG;
		charStr = Random.Range(20, 60) + clan_skill_bonus;
	
		if (charNickname != null)
		{
			FullCharName = charName + " the " charNickname;
		} else {
			FullCharName = charName + " of " + charFrom;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class SettlementKeepSpawn : MonoBehaviour {

	public int settlePop;
	public GameObject settlePeople;
	public int settleID;

	// Use this for initialization
	void Start () {

		settlePop = 8 * GameObject.Find("GameSetUp").GetComponent<GameInfo>().settlementAmount;
		settleID = GameObject.Find("GameSetUp").GetComponent<GameInfo>().SettlementID;
		for (int i = 0; i <= settlePop; i++)
		{
			float locX;
			float locZ;
			locX = gameObject.transform.position.x + (Random.Range(-5f,5f) + Mathf.Cos(i));
			locZ = gameObject.transform.position.z + (Random.Range(-5f,5f) + Mathf.Cos(i));

			Instantiate(settlePeople, new Vector3(locX, 0, locZ), Quaternion.identity);
			settlePeople.GetComponent<CharInfo>().factionID = settleID;
			string settleIDstring = settleID.ToString();
			settlePeople.tag = settleIDstring;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

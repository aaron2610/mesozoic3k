using UnityEngine;
using System.Collections;

public class SettlementSpawn : MonoBehaviour {

	public int settlePop;
	public GameObject settlePeople;
	public int settleID;

	// Use this for initialization
	void Awake () {

		settlePop = GameObject.Find("GameSetUp").GetComponent<GameInfo>().settlementAmount;
		settleID = GameObject.Find("GameSetUp").GetComponent<GameInfo>().SettlementID;

		for (int i = 0; i <= settlePop; i++)
		{
			float locX;
			float locZ;
			locX = gameObject.transform.position.x + Random.Range(-5f,5f);
			locZ = gameObject.transform.position.z + Random.Range(-5f,5f);

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

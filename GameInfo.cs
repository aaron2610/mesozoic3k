using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {

	public int settlementAmount;
	public GameObject SettlementPrefab;
	public GameObject SettlementKeep;
	public int SettlementID;

	// Use this for initialization
	void Start () {
		bool settlementKeep;
		int set_buildings;
		int locX;
		int locZ;

		for (int i = 0; i < settlementAmount; i++)
		{
			set_buildings = Random.Range(1,10);

			if(set_buildings >= 8)
			{
				locX = Random.Range(-300,300);
				locZ = Random.Range(-300,300);
				SettlementID = i;
				Instantiate(SettlementKeep, new Vector3(locX, 0, locZ), Quaternion.identity);

			} else {
				locX = Random.Range(-400,400);
				locZ = Random.Range(-400,400);
				for (int s = 0; s <= set_buildings; s++)
				{
					float locNewX;
					float locNewZ;
					locNewX = locX + (s*8) + Random.Range(35,50);
					locNewZ = locZ + (s*7) + Random.Range(40,60);
					SettlementID = i;
					Instantiate(SettlementPrefab, new Vector3(locNewX, 0, locNewZ), Quaternion.identity);

				}
			}


	}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

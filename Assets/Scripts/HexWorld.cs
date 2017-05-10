using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexWorld : MonoBehaviour {

	public GameObject HexPrefab;
	void Start () {
		int map_radius = 10;

		for (int q = -map_radius; q <= map_radius; q++) {
			int r1 = Mathf.Max(-map_radius, -q - map_radius);
			int r2 = Mathf.Min(map_radius, -q + map_radius);
			for (int r = r1; r <= r2; r++) {
				var hexn = new Hex(q, r);
				Instantiate(HexPrefab, hexn.Position(), Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}

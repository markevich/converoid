using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexWorld : MonoBehaviour {

	public GameObject HexPrefab;
	public int MapRadius = 10;
	void Start () {
		for (int q = -MapRadius; q <= MapRadius; q++) {
			int r1 = Mathf.Max(-MapRadius, -q - MapRadius);
			int r2 = Mathf.Min(MapRadius, -q + MapRadius);
			for (int r = r1; r <= r2; r++) {
				var hexn = new Hex(q, r);
				Instantiate(HexPrefab, hexn.Position(), Quaternion.identity);
			}
		}
		// StaticBatchingUtility.Combine( this.gameObject );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}

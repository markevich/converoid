using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Hex{
	public class HexWorld : MonoBehaviour {
		public Dictionary<string, GameObject> World;
		public GameObject HexPrefab;
		public int MapRadius = 10;
		void Start () {
			World = new Dictionary<string, GameObject>();
			for (int q = -MapRadius; q <= MapRadius; q++) {
				int r1 = Mathf.Max(-MapRadius, -q - MapRadius);
				int r2 = Mathf.Min(MapRadius, -q + MapRadius);
				for (int r = r1; r <= r2; r++) {
					var hexPosition = new HexPosition(q, r);

					var instance = (GameObject)Instantiate(HexPrefab, hexPosition.Position(), Quaternion.identity, this.transform);
					instance.GetComponent<Hex>().HexPosition = hexPosition;

					World.Add(hexPosition.ToString(), instance);
				}
			}
			// StaticBatchingUtility.Combine( this.gameObject );
		}
		
		// Update is called once per frame
		void Update () {
			
		}

	}

}

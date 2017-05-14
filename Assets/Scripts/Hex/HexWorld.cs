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
			
			StartCoroutine(GenerateWorld());
		}
		
		IEnumerator GenerateWorld(){
			for (int q = -MapRadius; q <= MapRadius; q++) {
				int r1 = Mathf.Max(-MapRadius, -q - MapRadius);
				int r2 = Mathf.Min(MapRadius, -q + MapRadius);
				for (int r = r1; r <= r2; r++) {
					var hexCoord = new HexCoord(q, r);

					var instance = (GameObject)Instantiate(HexPrefab, hexCoord.Position(), Quaternion.identity, this.transform);
					instance.GetComponent<Hex>().HexCoord = hexCoord;

					World.Add(hexCoord.ToString(), instance);
				}
				yield return new WaitForSeconds(0.01f);
				
			}
			// StaticBatchingUtility.Combine( this.gameObject );
		}
		// Update is called once per frame
		void Update () {
			Vector2 mousePosition = Input.mousePosition;
			var worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			
			var hexPosition = HexCoord.AtPosition(worldPosition).ToString();
			if (World.ContainsKey(hexPosition)){
				var selectedHexGO = World[hexPosition];
				selectedHexGO.GetComponent<Hex>().Selected = true;
			}
		}

	}

}

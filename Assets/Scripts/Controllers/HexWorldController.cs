using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using Models;

namespace Controllers
{
    public class HexWorldController : MonoBehaviour
    {
        public Dictionary<string, GameObject> world;
        public GameObject hexPrefab;
        public int mapRadius = 10;

        public static HexWorldController Instance;
        void Start()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            world = new Dictionary<string, GameObject>();

            GenerateWorld();
        }

        void GenerateWorld()
        {
            for (int q = -mapRadius; q <= mapRadius; q++)
            {
                int r1 = Mathf.Max(-mapRadius, -q - mapRadius);
                int r2 = Mathf.Min(mapRadius, -q + mapRadius);
                for (int r = r1; r <= r2; r++)
                {
                    CreateHex(q, r);
                }

            }
            // StaticBatchingUtility.Combine( this.gameObject );
        }

        private void CreateHex(int q, int r)
        {
            var hexCoordModel = new HexCoordModel(q, r);

            var instance = (GameObject)Instantiate(hexPrefab, hexCoordModel.Position(), Quaternion.identity, GameObject.Find("Tiles").transform);
            instance.GetComponent<HexModel>().hexCoordModel = hexCoordModel;
            instance.name = String.Format("Hex ({0}, {1})", q, r);
            world.Add(hexCoordModel.ToString(), instance);
        }

        // Update is called once per frame
        void Update()
        {
        }

        public HexModel GetHexAtWorldCoord(Vector3 worldCoord)
        {
            var hexCoord = HexCoordModel.AtPosition(worldCoord);
            var hexCoordKey = hexCoord.ToString();
            if (!world.ContainsKey(hexCoordKey))
            {
                CreateHex(hexCoord.q, hexCoord.r);
            }
            
            var selectedHexGO = world[hexCoordKey];
            var model = selectedHexGO.GetComponent<HexModel>();
            return model;
        }

    }

}

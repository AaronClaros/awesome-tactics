using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridGenerator : MonoBehaviour {
	public static GridGenerator instance;
	
	public GameObject TilePrefab;

	public int mapSideXSize = 11;
	public int mapSideYSize = 11;

	List <List<Tile>> map = new List<List<Tile>>();

	void Aweke(){
		instance = this;
	}
	// Use this for initialization
	void Start () {
		generateMap();
	}

	void generateMap() {
		map = new List<List<Tile>>();
		for (int i = 0; i < mapSideXSize; i++) {
			List <Tile> row = new List<Tile>();
			for (int j = 0; j < mapSideYSize; j++) {
				Tile tile = ((GameObject)Instantiate(TilePrefab, new Vector3(i - Mathf.Floor(mapSideXSize/2),0, -j + Mathf.Floor(mapSideYSize/2)), Quaternion.Euler(90,0,0))).GetComponent<Tile>();
				tile.gridPosition = new Vector2(i, j);
				row.Add (tile);
			}
			map.Add(row);
		}
	}
}

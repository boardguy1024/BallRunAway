using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class TileManager : MonoBehaviour {

	 
	public GameObject[] TilePrefabs;
	public GameObject CurrentTile;

	private Stack<GameObject> LeftTiles = new Stack<GameObject>();

	public Stack<GameObject> leftTiles {

		get{
			return LeftTiles;
		}
		set{

			LeftTiles = value;
		}


	}

	private Stack<GameObject> TopTiles  = new Stack<GameObject>();

	public Stack<GameObject>  topTiles {
		
		get {
			return  TopTiles;
		}
		set {
			
			TopTiles = value;
		}
	}




	private static TileManager _instance;
	public static TileManager instance {


		get{ 


			if(_instance == null)
			{
				_instance = GameObject.FindObjectOfType<TileManager>();
			}
			return _instance;
		}


	}




	// Use this for initialization
	void Start () {

		 
		
		//ゲームスタートと当時にタイルを50個生成
		CreatTiles (50);
		for (int i = 0; i < 50; i++) 
		{
			SpawnTile ();
		}
	}


	


	public void CreatTiles(int amount)
	{
		for (int i = 0; i < amount; i++) {

			LeftTiles.Push(Instantiate (TilePrefabs [0]));
			TopTiles.Push(Instantiate (TilePrefabs [1]));
			LeftTiles.Peek().name = "LeftTile";
			LeftTiles.Peek ().SetActive (false);
			TopTiles.Peek().name = "TopTile";
			TopTiles.Peek ().SetActive (false);
			LeftTiles.Push(Instantiate (TilePrefabs [2]));
			TopTiles.Push(Instantiate (TilePrefabs [3]));
			LeftTiles.Peek().name = "LeftTile";
			LeftTiles.Peek ().SetActive (false);
			TopTiles.Peek().name = "TopTile";
			TopTiles.Peek ().SetActive (false);
			LeftTiles.Push(Instantiate (TilePrefabs [4]));
			TopTiles.Push(Instantiate (TilePrefabs [5]));
			LeftTiles.Peek().name = "LeftTile";
			LeftTiles.Peek ().SetActive (false);
			TopTiles.Peek().name = "TopTile";
			TopTiles.Peek ().SetActive (false);
		}

	}

	public void SpawnTile()
	{
	  
		if (LeftTiles.Count == 0 || TopTiles.Count == 0)
		{
			CreatTiles(10);
		}

		int RandomIndex = Random.Range (0, 2);

		 if (RandomIndex == 0) {
			GameObject tmp = LeftTiles.Pop ();
			tmp.SetActive (true);

			tmp.transform.position = CurrentTile.transform.GetChild (0).transform.GetChild (RandomIndex).position;
			CurrentTile = tmp;


		} else if (RandomIndex == 1)
		{
			GameObject tmp = TopTiles.Pop();
			tmp.SetActive(true);

			tmp.transform.position = CurrentTile.transform.GetChild(0).transform.GetChild(RandomIndex).position;
			CurrentTile = tmp;


		}

		int SpawnPickUp = Random.Range (0, 10);

		if (SpawnPickUp == 0) 
		{
			CurrentTile.transform.GetChild(1).gameObject.SetActive(true);
			CurrentTile.transform.GetChild (1).gameObject.transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);

		}
	



	
	}



}

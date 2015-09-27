using UnityEngine;
using System.Collections;

public class TileScript : MonoBehaviour {

	 
	private float waitimeOfDrop = 0;


	void OnTriggerExit(Collider other)
	{
		if (other.tag == "Player") 
		{
			//ボールがタイルを抜け出たらタイルを生成する
			TileManager.instance.SpawnTile();
			// タイルを下に落とす
			StartCoroutine(FallDown());
		}
	}

	IEnumerator FallDown()
	{
		
		yield return new WaitForSeconds (waitimeOfDrop);
		GetComponent<Rigidbody> ().isKinematic = false;
		yield return new WaitForSeconds (3f);

		switch (gameObject.name)
		{
		case "LeftTile":
			TileManager.instance.leftTiles.Push(gameObject);
			gameObject.GetComponent<Rigidbody>().isKinematic = true;
			gameObject.SetActive(false);
			break;
		
		case "TopTile":
			TileManager.instance. topTiles.Push(gameObject);
			gameObject.GetComponent<Rigidbody>().isKinematic = true;
			gameObject.SetActive(false);
			break;
		}
	}


}

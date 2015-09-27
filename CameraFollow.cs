using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject Player;
	private Vector3 ShouldPos;
	public float cameraFollowSpeed;


	Vector3 offset;




	void Start()
	{
		
	}
		
	void Update () {



		ShouldPos = Vector3.Lerp (gameObject.transform.position, Player.transform.position , Time.deltaTime * cameraFollowSpeed);

		gameObject.transform.position = new Vector3 (ShouldPos.x  ,ShouldPos.y , ShouldPos.z );




	}
}

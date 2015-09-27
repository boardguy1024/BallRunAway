using UnityEngine;
using System.Collections;

public class ChangeFloorColor : MonoBehaviour {

	//スコアごとにタイルの色を変える

	Color color;
    GameObject _Player;


	private int PlayerScore;

	// Use this for initialization
	void Start () {



		_Player = GameObject.Find ("Player");



	}






		
	void Update () {


		if(_Player.transform.GetComponent<Player>().isDead != true)
		{
			PlayerScore = _Player.transform.GetComponent<Player> ().Score;
		}


		if(PlayerScore >= 50 || PlayerScore >= 1300 || PlayerScore >= 2550)
		{
			
			color = new Color (0.69f, 0.93f, 0.93f,1f);
			transform.GetComponent<Renderer> ().material.color = color;

		}
		if(PlayerScore >= 100 || PlayerScore >= 1350 || PlayerScore >= 2600)
		{
			color = new Color (0.68f, 0.85f, 0.90f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 150 || PlayerScore >= 1400  || PlayerScore >= 2650)
		{
			color = new Color (0.53f, 0.81f, 0.92f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 200 || PlayerScore >= 1450  || PlayerScore >= 2700)
		{
			color = new Color (0.28f, 0.82f, 0.80f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 250|| PlayerScore >= 1500 ||  PlayerScore >= 2750)
		{
			color = new Color (0.5f, 1f, 0.83f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 300|| PlayerScore >= 1550  || PlayerScore >= 2800)
		{
			color = new Color (0.6f, 0.98f, 0.6f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 350 || PlayerScore >= 1600  || PlayerScore >= 2850)
		{
			color = new Color (0f, 0.98f, 0.6f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 400 || PlayerScore >= 1650  || PlayerScore >= 2900)
		{
			color = new Color (0.49f, 0.99f, 0f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 450|| PlayerScore >= 1700  || PlayerScore >= 2950)
		{
			color = new Color (0.6f, 0.8f, 0.2f,1f);
			transform.GetComponent<Renderer> ().material.color = color;

		}
		if(PlayerScore >= 500|| PlayerScore >= 1750  || PlayerScore >= 3000)
		{
			color = new Color (0.74f, 0.72f, 0.42f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 550 || PlayerScore >= 1800 ||  PlayerScore >= 3050)
		{
			color = new Color (0.94f, 0.90f, 0.55f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 600|| PlayerScore >= 1850 ||  PlayerScore >= 3100)
		{
			color = new Color (0.93f, 0.91f, 0.67f,1f);
			transform.GetComponent<Renderer> ().material.color = color;

		}if(PlayerScore >= 650 || PlayerScore >= 1900 ||  PlayerScore >= 3150)
		{
			color = new Color (1f, 1, 0f,1f);
			transform.GetComponent<Renderer> ().material.color = color;

		}if(PlayerScore >= 700 || PlayerScore >= 1950  || PlayerScore >= 3200)
		{
			color = new Color (0.96f, 0.64f, 0.48f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 750 || PlayerScore >= 2000  || PlayerScore >= 3250)
		{
			color = new Color (0.98f, 0.5f, 0.45f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 800 || PlayerScore >= 2050  || PlayerScore >= 3300)
		{
			color = new Color (1f, 0.65f, 0f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 850 || PlayerScore >= 2100  || PlayerScore >= 3350)
		{
			color = new Color (1f, 0.39f, 0.28f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 900 || PlayerScore >= 2150  || PlayerScore >= 3400)
		{
			color = new Color (1f, 0.27f, 0f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 950 || PlayerScore >= 2200  || PlayerScore >= 3450)
		{
			color = new Color (1f, 0.41f, 0.71f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 1000|| PlayerScore >= 2250  || PlayerScore >= 3500)
		{
			color = new Color (0.86f, 0.44f, 0.58f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 1050 || PlayerScore >= 2300  || PlayerScore >= 3550)
		{
			color = new Color (0.82f, 0.13f, 0.56f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 1100 || PlayerScore >= 2350  || PlayerScore >= 3600)
		{
			color = new Color (0.85f, 0.44f, 0.84f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 1150 || PlayerScore >= 2400 ||  PlayerScore >= 3650)
		{
			color = new Color (0.63f, 0.13f, 0.94f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 1200 || PlayerScore >= 2450  || PlayerScore >= 3700)
		{
			color = new Color (1f, 0.41f, 0.71f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}
		if(PlayerScore >= 1250 || PlayerScore >= 2500  || PlayerScore >= 3750)
		{
			color = new Color (1f, 0f, 0f,1f);
			transform.GetComponent<Renderer> ().material.color = color;
		}




	}





}

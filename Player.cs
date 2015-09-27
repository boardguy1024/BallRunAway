using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;

public class Player : MonoBehaviour {

	public float Speed;

	private Vector3 dir; 

	public GameObject PS;
	public GameObject PS2;



	public bool isDead;


	public GameObject ChangeColorTile;

	public GameObject Camera;

	public GameObject _correntTile;


	public GameObject playbtn;



	private AudioSource  audioSource; 
	public AudioClip sound; 
	public AudioClip PickupSound;
	public AudioClip ballDown;

	public int Score;



	int HighScore;

	public Text CurrentScore;
	public Text ScoreText;
	public Text HighScoreText;

	public float bannerLimitTime;


	public void CheckHighScore()
	{


		if(Score > HighScore)
		{
			
			PlayerPrefs.SetInt("HighScore1", Score);
		}
	}



	// Use this for initialization
	void Start () {


		audioSource = gameObject.GetComponent<AudioSource>();
	
		dir = Vector3.zero;
		isDead = false;

		Score = 0;
		HighScore = PlayerPrefs.GetInt ("HighScore1",0);
		HighScoreText.text =  HighScore.ToString();

	
	}
		
	void Awake() { 
	    //60フレーム固定
		Application.targetFrameRate = 60;
	}

	// Update is called once per frame
	void  Update () {


		bannerLimitTime += Time.deltaTime;

		if (Input.GetMouseButtonDown (0) && !isDead ) 
		{



			//スコア +=1
			Score++;
			// 스트링타입으로 스코어텍스트에 대입!
			ScoreText.text = Score.ToString ();



			if(dir == Vector3.forward)
			{
				
				dir = Vector3.left;

				audioSource.PlayOneShot (sound,1f);

			}else
			{
				dir = Vector3.forward;
				audioSource.PlayOneShot (sound,1f);
			}

		}
			

		float amountToMove = Speed * Time.deltaTime;
		transform.Translate(dir * amountToMove);

		//increat game speed by a score num!


		//スコアごとにスピートアップと色変更
		switch(Score)
		{
		case 50:


			ScoreText.color = new Color (0.69f, 0.93f, 0.93f,0.5f);
			Speed = 12.3f;
			break;
		case 100:
			ScoreText.color = new Color (0.68f, 0.85f, 0.90f,0.5f);
			Speed = 12.6f;
			break;
		case 150:
			ScoreText.color = new Color (0.53f, 0.81f, 0.92f,0.5f);
			Speed = 12.9f;
			break;
		case 200:
			ScoreText.color = new Color (0.28f, 0.82f, 0.80f,0.5f);
			Speed = 13.1f;
			break;
		case 250:
			ScoreText.color = new Color (0.5f, 1f, 0.83f,0.5f);
			Speed = 13.4f;
			break;
		case 300:
			ScoreText.color = new Color (0.6f, 0.98f, 0.6f,0.5f);
			Speed = 13.7f;
			break;
		case 350:
			ScoreText.color = new Color (0f, 0.98f, 0.6f,0.5f);
			Speed = 14f;
			break;
		case 400:
			ScoreText.color = new Color (0.49f, 0.99f, 0f,0.5f);
			Speed = 14.3f;
			break;
		case 450:
			ScoreText.color = new Color (0.6f, 0.8f, 0.2f,0.5f);
			Speed = 14.6f;
			break;
		case 500:
			ScoreText.color = new Color (0.74f, 0.72f, 0.42f,0.5f);
			Speed = 14.9f;
			break;
		case 550:
			ScoreText.color = new Color (0.94f, 0.90f, 0.55f,0.5f);
			Speed = 15.2f;
			break;
		case 600:
			ScoreText.color = new Color (0.93f, 0.91f, 0.67f,0.5f);
			Speed = 15.5f;
			break;
		case 650:
			ScoreText.color = new Color (1f, 1, 0f,0.5f);
			Speed = 15.8f;
			break;
		case 700:
			ScoreText.color = new Color (0.96f, 0.64f, 0.48f,0.5f);
			Speed = 16.1f;
			break;
		case 750:
			ScoreText.color = new Color (0.98f, 0.5f, 0.45f,0.5f);
			Speed = 16.4f;
			break;
		case 800:
			ScoreText.color = new Color (1f, 0.65f, 0f,0.5f);
			Speed = 16.7f;
			break;
		case 850:
			ScoreText.color = new Color (1f, 0.39f, 0.28f,0.5f);
			Speed = 17f;
			break;
		case 900:
			ScoreText.color = new Color (1f, 0.27f, 0f,0.5f);
			Speed = 17.2f;
			break;
		case 950:
			ScoreText.color = new Color (1f, 0.41f, 0.71f,0.5f);
			Speed = 17.4f;
			break;
		case 1000:
			ScoreText.color = new Color (0.86f, 0.44f, 0.58f,0.5f);
			Speed = 17.6f;
			break;
		case 1050:
			ScoreText.color = new Color (0.82f, 0.13f, 0.56f,0.5f);
			Speed = 17.8f;
			break;
		case 1100:
			ScoreText.color = new Color (0.85f, 0.44f, 0.84f,0.5f);
			Speed = 18f;
			break;
		case 1150:
			ScoreText.color = new Color (0.63f, 0.13f, 0.94f,0.5f);
			Speed = 18f;
			break;
		case 1200:
			ScoreText.color = new Color (1f, 0.41f, 0.71f,0.5f);
			break;
		case 1250:
			ScoreText.color = new Color (1f, 0f, 0f,0.5f);
			break;
		case 1300:
			ScoreText.color = new Color (0.69f, 0.93f, 0.93f,0.5f);
			break;
		case 1350:
			ScoreText.color = new Color (0.68f, 0.85f, 0.90f,0.5f);
			break;
		case 1400:
			ScoreText.color = new Color (0.53f, 0.81f, 0.92f,0.5f);
			break;
		case 1450:
			ScoreText.color =  new Color (0.28f, 0.82f, 0.80f,0.5f);
			break;
		case 1500:
			ScoreText.color = new Color (0.5f, 1f, 0.83f,0.5f);
			break;
		case 1550:
			ScoreText.color = new Color (0.6f, 0.98f, 0.6f,0.5f);
			break;
		case 1600:
			ScoreText.color = new Color (0f, 0.98f, 0.6f,0.5f);
			break;
		case 1650:
			ScoreText.color = new Color (0.49f, 0.99f, 0f,0.5f);
			break;
		case 1700:
			ScoreText.color = new Color (0.6f, 0.8f, 0.2f,0.5f);
			break;
		case 1750:
			ScoreText.color = new Color (0.74f, 0.72f, 0.42f,0.5f);
			break;
		case 1800:
			ScoreText.color = new Color (0.94f, 0.90f, 0.55f,0.5f);
			break;
		case 1850:
			ScoreText.color = new Color (0.93f, 0.91f, 0.67f,0.5f);
			break;
		case 1900:
			ScoreText.color = new Color (1f, 1, 0f,0.5f);
			break;
		case 1950:
			ScoreText.color = new Color (0.96f, 0.64f, 0.48f,0.5f);
			break;
		case 2000:
			ScoreText.color = new Color (0.98f, 0.5f, 0.45f,0.5f);
			break;
		case 2050:
			ScoreText.color = new Color (1f, 0.65f, 0f,0.5f);
			break;
		case 2100:
			ScoreText.color = new Color (1f, 0.39f, 0.28f,0.5f);
			break;
		case 2150:
			ScoreText.color = new Color (1f, 0.27f, 0f,0.5f);
			break;
		case 2200:
			ScoreText.color = new Color (1f, 0.41f, 0.71f,0.5f);
			break;
		case 2250:
			ScoreText.color = new Color (0.86f, 0.44f, 0.58f,0.5f);
			break;
		case 2300:
			ScoreText.color = new Color (0.82f, 0.13f, 0.56f,0.5f);
			break;
		case 2350:
			ScoreText.color = new Color (0.85f, 0.44f, 0.84f,0.5f);
			break;
		case 2400:
			ScoreText.color = new Color (0.63f, 0.13f, 0.94f,1f);
			break;
		case 2450:
			ScoreText.color = new Color (1f, 0.41f, 0.71f,0.5f);
			break;
		case 2500:
			ScoreText.color =  new Color (1f, 0f, 0f,0.5f);
			break;
		case 2550:
			ScoreText.color  = new Color (0.69f, 0.93f, 0.93f,0.5f);
			break;
		case 2600:
			ScoreText.color = new Color (0.68f, 0.85f, 0.90f,0.5f);
			break;
		case 2700:
			ScoreText.color = new Color (0.53f, 0.81f, 0.92f,0.5f);
			break;
		case 2750:
			ScoreText.color = new Color (0.28f, 0.82f, 0.80f,0.5f);
			break;
		case 2800:
			ScoreText.color = new Color (0.6f, 0.98f, 0.6f,0.5f);
			break;
		case 2850:
			ScoreText.color = new Color (0f, 0.98f, 0.6f,0.5f);
			break;
		case 2900:
			ScoreText.color = new Color (0.49f, 0.99f, 0f,0.5f);
			break;
		case 2950:
			ScoreText.color = new Color (0.6f, 0.8f, 0.2f,0.5f);
			break;
		case 3000:
			ScoreText.color = new Color (0.74f, 0.72f, 0.42f,0.5f);
			break;
		case 3050:
			ScoreText.color = new Color (0.94f, 0.90f, 0.55f,0.5f);
			break;
		case 3100:
			ScoreText.color = new Color (0.93f, 0.91f, 0.67f,0.5f);
			break;
		case 3150:
			ScoreText.color = new Color (1f, 1, 0f,0.5f);
			break;
		case 3200:
			ScoreText.color = new Color (0.96f, 0.64f, 0.48f,0.5f);
			break;
		default:
			break;

		}

		CheckHighScore ();

	}

	void OnTriggerEnter(Collider other)
	{
		//ダイヤと衝突した時の処理
		if (other.tag == "PickUp")
		{
			
			Score += 2;
			ScoreText.text = Score.ToString ();

			audioSource.PlayOneShot (PickupSound, 1f);
			other.gameObject.SetActive(false);
			Instantiate(PS,transform.position,Quaternion.identity);
			Instantiate(PS2,transform.position,Quaternion.identity);

		}
	}


	 void OnTriggerExit(Collider other)
	{
		//  ボールがタイルから外れた時
		if (other.tag == "Tile") 
		{
			RaycastHit hit;  

			Ray downRay = new Ray(transform.position,-Vector3.up);

		
			if (!Physics.Raycast (downRay, out hit))   
			{
				isDead = true;

					AudioSource _balldownspeed = transform.GetComponent<AudioSource> ();

					_balldownspeed.pitch = 1;

					_balldownspeed.PlayOneShot (ballDown);


				//全面バナーのインスタンス
				AdMobManager admobmanager = (AdMobManager)FindObjectOfType(typeof(AdMobManager));


				//全面広告を実行する
				if(bannerLimitTime >= 50f)
				{
					if (admobmanager.interstitial.IsLoaded ()) {
						admobmanager.interstitial.Show ();
					}

				}

				//追いかけるカメラを止める
				GameObject camera = GameObject.Find ("camera");
				camera.GetComponent<CameraFollow> ().enabled = false;

				CurrentScore.text = Score.ToString() ;
				
			    HighScore = PlayerPrefs.GetInt ("HighScore1",0);
				HighScoreText.text =  HighScore.ToString();



				//ボタンを表示
				var playbtn = GameObject.Find ("Canvas");
				playbtn.transform.GetChild (1).transform.GetComponent<Animator> ().enabled = true;
				playbtn.transform.GetChild (2).transform.GetComponent<Animator> ().enabled = true;
				playbtn.transform.GetChild (0).transform.GetComponent<Text> ().enabled = false;

				StartCoroutine ("KillsPlayer");



				Social.LoadScores("com.ninimepaku.BallGame", scores => {
					if (scores.Length > 0) {

						Debug.Log ("保有: " + scores.Length + " 個のスコア");
						string myScores = "Leaderboard:\n";
						foreach (IScore score in scores)
							myScores += "\t" + score.userID + " " + score.formattedValue + " " + score.date + "\n";

						Debug.Log (myScores);
					}
					else

						Debug.Log ("スコアはロードされませんでした。");
				});


			}

		}
	}

	IEnumerator KillsPlayer()
	{
		yield return new WaitForSeconds(3f);

		Collider Stopfalldown =  transform.GetComponent<Collider> ();
		Stopfalldown.attachedRigidbody.useGravity = false;

	}


}

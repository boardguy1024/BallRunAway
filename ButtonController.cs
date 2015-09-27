using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public GameObject SpeakerOff2;
	 
	// 쉐어용 이미지 패스 (스크린샷)
	string imagePath
	{
		get
		{
			return Application.persistentDataPath + "/image.png";
		}
	}


	void Awake()
	{
		if (PlayerPrefs.GetInt("Mute", 0) == 0)
		{
			AudioListener.volume = 1f;

		} else
		{
			AudioListener.volume = 0f;

		}




	}


	void Start()
	{
		
		SpeakerOff2 = GameObject.FindWithTag ("SP");

		if(AudioListener.volume == 1)
		{
			SpeakerOff2.SetActive (false);
		}

	}

	// mainplay
	public void ResetPlayLevel()
	{

		Application.LoadLevel("1_Play");
	}

	//play
	public void ResetLevel()
	{

		Application.LoadLevel (Application.loadedLevel);
	}


	public void RateBtn()
	{
		Application.OpenURL("itms-apps://itunes.apple.com/WebObjects/MZStore.woa/wa/viewContentsUserReviews?id=1035571683&onlyLatestVersion=true&pageNumber=0&sortOrdering=1&type=Purple+Software");

	}

	public void Facebook()
	{

		StartCoroutine (Share ());

	}


	IEnumerator Share()
	{
		
		Application.CaptureScreenshot("image.png");
		// スクリーンショットの撮影に1フレーム待機
		yield return new WaitForSeconds(0.8f);
		SocialConnector.Share ("Let's Play Ball Runaway", "http://itunes.apple.com/WebObjects/MZStore.woa/wa/viewSoftware?id=1035571683\n",imagePath);

	}



	public void SpeakerController()
	{
		if (PlayerPrefs.GetInt ("Mute", 0) == 0) {
			AudioListener.volume = 0f;
			PlayerPrefs.SetInt ("Mute", 1);

			SpeakerOff2.SetActive (true);


		} else {
			
			AudioListener.volume = 1f;
			PlayerPrefs.SetInt ("Mute", 0);

			SpeakerOff2.SetActive (false);


		}

	}


	


}

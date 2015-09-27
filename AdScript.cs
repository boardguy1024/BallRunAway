using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdScript : MonoBehaviour {





	// Use this for initialization
	void Start () {
		RequestBanner();
	}


/*   배너 사이즈 선택 
 *   AdSize Banner = new AdSize(320, 50);
     AdSize MediumRectangle = new AdSize(300, 250);
     AdSize IABBanner = new AdSize(468, 60);
     AdSize Leaderboard = new AdSize(728, 90);
     AdSize SmartBanner = new AdSize(true);
 * 
 * 
 * 
 */


	private void RequestBanner()
	{
		#if UNITY_ANDROID
		string adUnitId = "INSERT_ANDROID_BANNER_AD_UNIT_ID_HERE";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-9376744719176721/6149483695";
		#else
		string adUnitId = "unexpected_platform";
		#endif


		// Create a 320x50 banner at the top of the screen.
		BannerView bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);
		// Create an empty ad request.

		AdRequest request = new AdRequest.Builder().Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
	}
}
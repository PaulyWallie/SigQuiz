using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LoadManager : MonoBehaviour {

	Button questionButton;
	
	void Start(){
		questionButton = gameObject.GetComponent<Button>();
	}
	
	public void Loadlevel(string name){
		Debug.Log("Level load requested for "+name);
		Application.LoadLevel(name);
		
	}

	public void QuitRequested(){
		Ads.ShowAd();
		Debug.Log("I want to quit");
		Application.Quit();
		}

	public void Donate(){
		Application.OpenURL("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=F6DWVDDP4VUT4");
		}
}

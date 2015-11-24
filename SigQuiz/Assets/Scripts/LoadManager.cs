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
		Debug.Log("I want to quit");
		Application.Quit();
		}
		
	public void DisableButton(){
		questionButton.gameObject.SetActive(false);
	}
}

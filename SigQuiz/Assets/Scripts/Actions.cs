using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Actions : MonoBehaviour {
	
	[SerializeField]
	GameObject questionPanel, mainCanvas;
	
	[SerializeField]
	GameObject[] questions;
	
	[SerializeField]
	Button[] questionButton;
	
	
	public void ShowGenaral100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[0].gameObject.SetActive (true);
		questionButton[0].gameObject.SetActive (false);
	}
	
	public void Reward100(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Reward200(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Reward300(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Reward400(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Reward500(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Lose100(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Lose200(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Lose300(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Lose400(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
	
	public void Lose500(){
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class test : MonoBehaviour {
	
	public Button question;

	void MouseDown(){
		DontDestroyOnLoad(question);
		question.enabled = false;
	}
}
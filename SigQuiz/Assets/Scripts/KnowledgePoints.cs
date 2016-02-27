using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KnowledgePoints : MonoBehaviour {

	public static int knowledgePoints;

	[SerializeField]
	Text text;

	// Use this for initialization
	void Start () {
		knowledgePoints = 0;
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "" + knowledgePoints;
	}
}

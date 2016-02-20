using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Actions : MonoBehaviour {
	
	[SerializeField]
	GameObject questionPanel, mainCanvas, endGameCanvas;
	
	[SerializeField]
	GameObject[] questions, categories;
	
	[SerializeField]
	Button[] questionButton;

	public void Update(){
		if(questionButton[0] == null && questionButton[1] == null && questionButton[2] == null && questionButton[3] == null && questionButton[4] == null && questionButton[5] == null && questionButton[6] == null && questionButton[7] == null && questionButton[8] == null && questionButton[9] == null && questionButton[10] == null && questionButton[11] == null && questionButton[12] == null && questionButton[13] == null && questionButton[14] == null &&questionButton[15] == null && questionButton[16] == null && questionButton[17] == null && questionButton[18] == null && questionButton[19] == null && questionButton[20] == null && questionButton[21] == null && questionButton[22] == null && questionButton[23] && questionButton[24] == null){
			StartCoroutine(EndgamePanel());
		}
	}

	IEnumerator EndgamePanel(){
		yield return new WaitForSeconds(5f);
		mainCanvas.SetActive (false);
		endGameCanvas.SetActive (true);
	}
	
	public void General100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[0].gameObject.SetActive (true);
		questionButton[0].gameObject.SetActive (false);
	}
	
	public void General200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[1].gameObject.SetActive (true);
		questionButton[1].gameObject.SetActive (false);
	}

	public void General300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[2].gameObject.SetActive (true);
		questionButton[2].gameObject.SetActive (false);
	}

	public void General400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[3].gameObject.SetActive (true);
		questionButton[3].gameObject.SetActive (false);
	}

	public void General500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[4].gameObject.SetActive (true);
		questionButton[4].gameObject.SetActive (false);
	}

	public void Founders100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[5].gameObject.SetActive (true);
		questionButton[5].gameObject.SetActive (false);
	}

	public void Founders200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[6].gameObject.SetActive (true);
		questionButton[6].gameObject.SetActive (false);
	}

	public void Founders300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[7].gameObject.SetActive (true);
		questionButton[7].gameObject.SetActive (false);
	}

	public void Founders400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[8].gameObject.SetActive (true);
		questionButton[8].gameObject.SetActive (false);
	}

	public void Founders500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[9].gameObject.SetActive (true);
		questionButton[9].gameObject.SetActive (false);
	}

	public void TheJordenStandard100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[10].gameObject.SetActive (true);
		questionButton[10].gameObject.SetActive (false);
	}

	public void TheJordenStandard200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[11].gameObject.SetActive (true);
		questionButton[11].gameObject.SetActive (false);
	}

	public void TheJordenStandard300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[12].gameObject.SetActive (true);
		questionButton[12].gameObject.SetActive (false);
	}

	public void TheJordenStandard400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[13].gameObject.SetActive (true);
		questionButton[13].gameObject.SetActive (false);
	}

	public void TheJordenStandard500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[14].gameObject.SetActive (true);
		questionButton[14].gameObject.SetActive (false);
	}

	public void TheSigmaChiCreed100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[15].gameObject.SetActive (true);
		questionButton[15].gameObject.SetActive (false);
	}

	public void TheSigmaChiCreed200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[16].gameObject.SetActive (true);
		questionButton[16].gameObject.SetActive (false);
	}

	public void TheSigmaChiCreed300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[17].gameObject.SetActive (true);
		questionButton[17].gameObject.SetActive (false);
	}

	public void TheSigmaChiCreed400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[18].gameObject.SetActive (true);
		questionButton[18].gameObject.SetActive (false);
	}

	public void TheSigmaChiCreed500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[19].gameObject.SetActive (true);
		questionButton[19].gameObject.SetActive (false);
	}

	public void TheSpiritOfSigmaChi100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[20].gameObject.SetActive (true);
		questionButton[20].gameObject.SetActive (false);
	}

	public void TheSpiritOfSigmaChi200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[21].gameObject.SetActive (true);
		questionButton[21].gameObject.SetActive (false);
	}

	public void TheSpiritOfSigmaChi300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[22].gameObject.SetActive (true);
		questionButton[22].gameObject.SetActive (false);
	}

	public void TheSpiritOfSigmaChi400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[23].gameObject.SetActive (true);
		questionButton[23].gameObject.SetActive (false);
	}

	public void TheSpiritOfSigmaChi500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[24].gameObject.SetActive (true);
		questionButton[24].gameObject.SetActive (false);
	}

	
	public void GeneralReward100(){
		KnowledgePoints.knowledgePoints += 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[0].SetActive(false);
	}

	public void GeneralReward200(){
		KnowledgePoints.knowledgePoints += 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[1].SetActive(false);
	}

	public void GeneralReward300(){
		KnowledgePoints.knowledgePoints += 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[2].SetActive(false);
	}

	public void GeneralReward400(){
		KnowledgePoints.knowledgePoints += 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[3].SetActive(false);
	}

	public void GeneralReward500(){
		KnowledgePoints.knowledgePoints += 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[4].SetActive(false);
	}

	public void FoundersReward100(){
		KnowledgePoints.knowledgePoints += 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[5].SetActive(false);
	}

	public void FoundersReward200(){
		KnowledgePoints.knowledgePoints += 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[6].SetActive(false);
	}

	public void FoundersReward300(){
		KnowledgePoints.knowledgePoints += 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[7].SetActive(false);
	}

	public void FoundersReward400(){
		KnowledgePoints.knowledgePoints += 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[8].SetActive(false);
	}

	public void FoundersReward500(){
		KnowledgePoints.knowledgePoints += 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[9].SetActive(false);
	}

	public void TheJordenStandardReward100(){
		KnowledgePoints.knowledgePoints += 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[10].SetActive(false);
	}

	public void TheJordenStandardReward200(){
		KnowledgePoints.knowledgePoints += 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[11].SetActive(false);
	}

	public void TheJordenStandardReward300(){
		KnowledgePoints.knowledgePoints += 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[12].SetActive(false);
	}

	public void TheJordenStandardReward400(){
		KnowledgePoints.knowledgePoints += 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[13].SetActive(false);
	}

	public void TheJordenStandardReward500(){
		KnowledgePoints.knowledgePoints += 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[14].SetActive(false);
	}

	public void TheSigmaChiCreedReward100(){
		KnowledgePoints.knowledgePoints += 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[15].SetActive(false);
	}

	public void TheSigmaChiCreedReward200(){
		KnowledgePoints.knowledgePoints += 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[16].SetActive(false);
	}

	public void TheSigmaChiCreedReward300(){
		KnowledgePoints.knowledgePoints += 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[17].SetActive(false);
	}

	public void TheSigmaChiCreedReward400(){
		KnowledgePoints.knowledgePoints += 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[18].SetActive(false);
	}

	public void TheSigmaChiCreedReward500(){
		KnowledgePoints.knowledgePoints += 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[19].SetActive(false);
	}

	public void TheSpiritOfSigmaChiReward100(){
		KnowledgePoints.knowledgePoints += 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[20].SetActive(false);
	}

	public void TheSpiritOfSigmaChiReward200(){
		KnowledgePoints.knowledgePoints += 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[21].SetActive(false);
	}

	public void TheSpiritOfSigmaChiReward300(){
		KnowledgePoints.knowledgePoints += 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[22].SetActive(false);
	}

	public void TheSpiritOfSigmaChiReward400(){
		KnowledgePoints.knowledgePoints += 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[23].SetActive(false);
	}

	public void TheSpiritOfSigmaChiReward500(){
		KnowledgePoints.knowledgePoints += 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[24].SetActive(false);
	}


	public void GeneralLose100(){
		KnowledgePoints.knowledgePoints -= 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[0].SetActive(false);
	}

	public void GeneralLose200(){
		KnowledgePoints.knowledgePoints -= 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[1].SetActive(false);
	}

	public void GeneralLose300(){
		KnowledgePoints.knowledgePoints -= 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[2].SetActive(false);
	}

	public void GeneralLose400(){
		KnowledgePoints.knowledgePoints -= 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[3].SetActive(false);
	}

	public void GeneralLose500(){
		KnowledgePoints.knowledgePoints -= 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[4].SetActive(false);
	}

	public void FoundersLose100(){
		KnowledgePoints.knowledgePoints-= 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[5].SetActive(false);
	}

	public void FoundersLose200(){
		KnowledgePoints.knowledgePoints -= 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[6].SetActive(false);
	}

	public void FoundersLose300(){
		KnowledgePoints.knowledgePoints -= 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[7].SetActive(false);
	}

	public void FoundersLose400(){
		KnowledgePoints.knowledgePoints -= 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[8].SetActive(false);
	}

	public void FoundersLose500(){
		KnowledgePoints.knowledgePoints -= 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[9].SetActive(false);
	}

	public void TheJordenStandardLose100(){
		KnowledgePoints.knowledgePoints -= 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[10].SetActive(false);
	}

	public void TheJordenStandardLose200(){
		KnowledgePoints.knowledgePoints -= 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[11].SetActive(false);
	}

	public void TheJordenStandardLose300(){
		KnowledgePoints.knowledgePoints -= 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[12].SetActive(false);
	}

	public void TheJordenStandardLose400(){
		KnowledgePoints.knowledgePoints -= 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[13].SetActive(false);
	}

	public void TheJordenStandardLose500(){
		KnowledgePoints.knowledgePoints -= 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[14].SetActive(false);
	}

	public void TheSigmaChiCreedLose100(){
		KnowledgePoints.knowledgePoints -= 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[15].SetActive(false);
	}

	public void TheSigmaChiCreedLose200(){
		KnowledgePoints.knowledgePoints -= 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[16].SetActive(false);
	}

	public void TheSigmaChiCreedLose300(){
		KnowledgePoints.knowledgePoints -= 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[17].SetActive(false);
	}

	public void TheSigmaChiCreedLose400(){
		KnowledgePoints.knowledgePoints -= 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[18].SetActive(false);
	}

	public void TheSigmaChiCreedLose500(){
		KnowledgePoints.knowledgePoints -= 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[19].SetActive(false);
	}

	public void TheSpiritOfSigmaChiLose100(){
		KnowledgePoints.knowledgePoints -= 100;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[20].SetActive(false);
	}

	public void TheSpiritOfSigmaChiLose200(){
		KnowledgePoints.knowledgePoints -= 200;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[21].SetActive(false);
	}

	public void TheSpiritOfSigmaChiLose300(){
		KnowledgePoints.knowledgePoints -= 300;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[22].SetActive(false);
	}

	public void TheSpiritOfSigmaChiLose400(){
		KnowledgePoints.knowledgePoints -= 400;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[23].SetActive(false);
	}

	public void TheSpiritOfSigmaChiLose500(){
		KnowledgePoints.knowledgePoints -= 500;
		questionPanel.SetActive (false);
		mainCanvas.gameObject.SetActive(true);
		questions[24].SetActive(false);
	}
}

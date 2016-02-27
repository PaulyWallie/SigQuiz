using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Actions : MonoBehaviour {
	
	[SerializeField]
	GameObject questionPanel, mainCanvas, endGameCanvas;
	
	[SerializeField]
	GameObject[] questions, questionButtons, categories;

	public void Update(){
		if(questionButtons[0] == null && questionButtons[1] == null && questionButtons[2] == null && questionButtons[3] == null && questionButtons[4] == null && questionButtons[5] == null && questionButtons[6] == null && questionButtons[7] == null && questionButtons[8] == null && questionButtons[9] == null && questionButtons[10] == null && questionButtons[11] == null && questionButtons[12] == null && questionButtons[13] == null && questionButtons[14] == null && questionButtons[15] == null && questionButtons[16] == null && questionButtons[17] == null && questionButtons[18] == null && questionButtons[19] == null && questionButtons[20] == null && questionButtons[21] == null && questionButtons[22] == null && questionButtons[23] ==null && questionButtons[24] == null && questionPanel.activeInHierarchy == false){
			categories[0].SetActive(false);
			categories[1].SetActive(false);
			categories[2].SetActive(false);
			categories[3].SetActive(false);
			categories[4].SetActive(false);
			endGameCanvas.SetActive(true);
		}
	}


	
	public void General100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[0].gameObject.SetActive (true);
		questionButtons[0].gameObject.SetActive (false);
		Destroy(questionButtons[0]);
	}
	
	public void General200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[1].gameObject.SetActive (true);
		questionButtons[1].gameObject.SetActive (false);
		Destroy(questionButtons[1]);
	}

	public void General300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[2].gameObject.SetActive (true);
		questionButtons[2].gameObject.SetActive (false);
		Destroy(questionButtons[2]);
	}

	public void General400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[3].gameObject.SetActive (true);
		questionButtons[3].gameObject.SetActive (false);
		Destroy(questionButtons[3]);
	}

	public void General500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[4].gameObject.SetActive (true);
		questionButtons[4].gameObject.SetActive (false);
		Destroy(questionButtons[4]);
	}

	public void Founders100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[5].gameObject.SetActive (true);
		questionButtons[5].gameObject.SetActive (false);
		Destroy(questionButtons[5]);
	}

	public void Founders200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[6].gameObject.SetActive (true);
		questionButtons[6].gameObject.SetActive (false);
		Destroy(questionButtons[6]);
	}

	public void Founders300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[7].gameObject.SetActive (true);
		questionButtons[7].gameObject.SetActive (false);
		Destroy(questionButtons[7]);
	}

	public void Founders400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[8].gameObject.SetActive (true);
		questionButtons[8].gameObject.SetActive (false);
		Destroy(questionButtons[8]);
	}

	public void Founders500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[9].gameObject.SetActive (true);
		questionButtons[9].gameObject.SetActive (false);
		Destroy(questionButtons[9]);
	}

	public void TheJordenStandard100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[10].gameObject.SetActive (true);
		questionButtons[10].gameObject.SetActive (false);
		Destroy(questionButtons[10]);
	}

	public void TheJordenStandard200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[11].gameObject.SetActive (true);
		questionButtons[11].gameObject.SetActive (false);
		Destroy(questionButtons[11]);
	}

	public void TheJordenStandard300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[12].gameObject.SetActive (true);
		questionButtons[12].gameObject.SetActive (false);
		Destroy(questionButtons[12]);
	}

	public void TheJordenStandard400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[13].gameObject.SetActive (true);
		questionButtons[13].gameObject.SetActive (false);
		Destroy(questionButtons[13]);
	}

	public void TheJordenStandard500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[14].gameObject.SetActive (true);
		questionButtons[14].gameObject.SetActive (false);
		Destroy(questionButtons[14]);
	}

	public void TheSigmaChiCreed100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[15].gameObject.SetActive (true);
		questionButtons[15].gameObject.SetActive (false);
		Destroy(questionButtons[15]);
	}

	public void TheSigmaChiCreed200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[16].gameObject.SetActive (true);
		questionButtons[16].gameObject.SetActive (false);
		Destroy(questionButtons[16]);
	}

	public void TheSigmaChiCreed300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[17].gameObject.SetActive (true);
		questionButtons[17].gameObject.SetActive (false);
		Destroy(questionButtons[17]);
	}

	public void TheSigmaChiCreed400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[18].gameObject.SetActive (true);
		questionButtons[18].gameObject.SetActive (false);
		Destroy(questionButtons[18]);
	}

	public void TheSigmaChiCreed500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[19].gameObject.SetActive (true);
		questionButtons[19].gameObject.SetActive (false);
		Destroy(questionButtons[19]);
	}

	public void TheSpiritOfSigmaChi100(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[20].gameObject.SetActive (true);
		questionButtons[20].gameObject.SetActive (false);
		Destroy(questionButtons[20]);
	}

	public void TheSpiritOfSigmaChi200(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[21].gameObject.SetActive (true);
		questionButtons[21].gameObject.SetActive (false);
		Destroy(questionButtons[21]);
	}

	public void TheSpiritOfSigmaChi300(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[22].gameObject.SetActive (true);
		questionButtons[22].gameObject.SetActive (false);
		Destroy(questionButtons[22]);
	}

	public void TheSpiritOfSigmaChi400(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[23].gameObject.SetActive (true);
		questionButtons[23].gameObject.SetActive (false);
		Destroy(questionButtons[23]);
	}

	public void TheSpiritOfSigmaChi500(){
		questionPanel.SetActive (true);
		mainCanvas.gameObject.SetActive(false);
		questions[24].gameObject.SetActive (true);
		questionButtons[24].gameObject.SetActive (false);
		Destroy(questionButtons[24]);
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

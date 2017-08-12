using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class button : MonoBehaviour {



	public Text bestText;
	public int bestScore = 0;


	void Start(){

		bestScore = PlayerPrefs.GetInt ("BestScore", 0);

		bestText.text = "Best : " + bestScore.ToString();

	}


	void Update(){

		if (Input.GetKeyDown(KeyCode.Escape)) { 
			
			Application.Quit(); 
			
			
		}

	}
   

	public void loadLevel1(){

		Application.LoadLevel ("gameScene");
	}
}





//NixonOk




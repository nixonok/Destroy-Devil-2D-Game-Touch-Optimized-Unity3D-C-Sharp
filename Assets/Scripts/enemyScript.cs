using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class enemyScript: MonoBehaviour {

	public GameObject mask;
	private int i;
	private int life = 3;
	public int counter = -1;
	public int bestScore; 
	public Text scoreText;
	public Text bestText;
	public Text lifeText;
	public Text gameOverText;
	public Text newScore;
	public Text restartText;
	private bool gameRunning = true;
	private int preScore;


	

	void Start() {
		StartCoroutine (spawnTheMask ());
		scoreCounterFunction ();
		newScore.text = "";

		bestScore = PlayerPrefs.GetInt ("BestScore",0);
		preScore = bestScore;
		if (bestScore > 0) {



			bestText.text = "Best : " + bestScore.ToString();

		} else {

			bestText.text = "Best : 0";
		}

		gameOverText.text = "";
		restartText.text = "";

		restartText.rectTransform.anchoredPosition = new Vector2 ( -10f , -420f );

	}

	void Update(){



		if (Input.GetKeyDown(KeyCode.Escape)) { 
			
			Application.LoadLevel ("menu"); 
			
			
		}

	}







	public void loadLevel1(){
		
		Application.LoadLevel ("gameScene");
	}


	public int scoreCounterFunction(){
		counter++;


		scoreText.text = "Score : " + counter.ToString();


		if( bestScore <= counter){

			bestScore = counter;
			bestText.text = "Best : " + bestScore.ToString();


		}

		return counter;
	}

	public void lifeCounter(){
		if (life > 0) {
			life--;
		}
		lifeText.text = "Life : " + life.ToString ();

		if (life > 0) {


			lifeText.text = "Life : " + life.ToString ();

		} else {

			//Time.timeScale = 0;
			gameOverText.text = "Game Over";
			restartText.text = "Tap To Restart";
			gameRunning = false;

			PlayerPrefs.SetInt("BestScore", bestScore);

			restartText.rectTransform.anchoredPosition = new Vector2 ( -10f , -340f );

			if ( bestScore > preScore){
				newScore.text = "New Best : " + bestScore.ToString() ;
			}


		}

	}


	IEnumerator spawnTheMask(){

		while(gameRunning == true){

			Vector3 position = new Vector3(Random.Range(-15F, 15F), Random.Range(11.7F, 15.7F), 0);
			Instantiate(mask, position, Quaternion.identity);
			yield return new WaitForSeconds(0.5F);
		}



	}
}





//NixonOk












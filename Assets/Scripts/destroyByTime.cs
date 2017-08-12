using UnityEngine;
using System.Collections;

public class destroyByTime : MonoBehaviour {

	public float lifeTime;

	public string touched = "NULL";

	public bool tapped = false;

	void Start(){
		Destroy (this.gameObject, lifeTime);
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) 
		{
			RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
			
			if(hit.collider != null)
			{
				if(hit.collider.gameObject==gameObject) 
					Destroy(this.gameObject);
				touched = "YEAP";
				GameObject go = GameObject.Find ("gameController");
				go.GetComponent<enemyScript>().scoreCounterFunction();

				tapped = true;
			}
		}
	}

	void OnDestroy() {
		if (tapped == false) {
			GameObject go = GameObject.Find ("gameController");
			go.GetComponent<enemyScript>().lifeCounter();
		}
	}
	

}






//NixonOk



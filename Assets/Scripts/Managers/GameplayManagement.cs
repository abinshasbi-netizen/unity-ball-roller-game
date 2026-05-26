using UnityEngine;

public class GameplayManagement : MonoBehaviour
{
    public static GameplayManagement Instance {  get; private set; }

	public GameObject menupanel;


	private void Awake()
	{
		if (Instance != null && Instance != this)
		{

			Destroy(gameObject);

		}
		Instance = this;

		menupanel.SetActive(true);
		Time.timeScale = 0f;
	}

	public void StartGame() {

		menupanel.SetActive(false);
		Time.timeScale = 1.0f;
	}

	public void Gameover() { 

	Time.timeScale = 0f;
    
    }
}

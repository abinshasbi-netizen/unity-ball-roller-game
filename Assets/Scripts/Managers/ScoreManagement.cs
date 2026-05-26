using TMPro;
using UnityEngine;

public class ScoreManagement : MonoBehaviour
{
	public static ScoreManagement Instance { get; private set; }
	[SerializeField] TextMeshProUGUI scoretext;
	 public static int score;

	private void Awake()
	{
		if (Instance != null && Instance != this)
		{

			Destroy(gameObject);

		}
		Instance = this;

		score = 0;
	}

	public void ScoreUpdate(){

		score++;
		scoretext.text = $"STARS: {score}";

   }
}

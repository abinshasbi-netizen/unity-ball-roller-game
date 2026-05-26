using UnityEngine;

public class StarCollect : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
	   if(other.CompareTag("Player")){

			gameObject.SetActive(false);
			Audiomanagement.Instance.PlayCollect();
			ScoreManagement.Instance.ScoreUpdate();

		} 

		
	}
}

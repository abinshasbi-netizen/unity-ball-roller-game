using UnityEngine;

public class Checkpoint : MonoBehaviour
{

	public Transform spawnpoint;
	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player")){

			Respawning respawning =
		    other.GetComponent<Respawning>();

			respawning.SpawnUpdate(spawnpoint);
		    gameObject.SetActive(false);
		}
	}
}

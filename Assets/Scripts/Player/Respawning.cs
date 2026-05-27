using UnityEngine;

public class Respawning : MonoBehaviour
{
	 public Transform spawnPoint;
	[SerializeField] Rigidbody rb;


	public void SpawnUpdate(Transform spawnpoint) { 

	 spawnPoint = spawnpoint;
	
	}
	private void Update()
	{
		if (transform.position.y < -10f)
		{
			Respawn();
		}
	}

	void Respawn()
	{
		rb.linearVelocity = Vector3.zero;

		transform.position = spawnPoint.position;
	}
}

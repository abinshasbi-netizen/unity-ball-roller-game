using UnityEngine;

public class StarCollect : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		gameObject.SetActive(false);
		Audiomanagement.Instance.PlayCollect();
	}
}

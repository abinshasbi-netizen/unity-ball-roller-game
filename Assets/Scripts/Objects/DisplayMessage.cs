using TMPro;
using UnityEngine;

public class DisplayMessage : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI text;

	[TextArea]
	public string message;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			text.text = message;

			text.gameObject.SetActive(true);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			text.gameObject.SetActive(false);
		}
	}
}

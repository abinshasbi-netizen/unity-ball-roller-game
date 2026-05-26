using TMPro;
using UnityEngine;

public class DisplayMessage : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI text;
	public bool isFinish;

	[TextArea]
	public string message;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			text.text = message;

			text.gameObject.SetActive(true);

			if (isFinish) {
				GameplayManagement.Instance.Gameover();
			}
			
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

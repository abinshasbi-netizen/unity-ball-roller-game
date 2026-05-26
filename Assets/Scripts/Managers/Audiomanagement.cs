using UnityEngine;

public class Audiomanagement : MonoBehaviour
{
	public static Audiomanagement Instance { get; private set; }

	[SerializeField] AudioClip collectclip;

	AudioSource oneshotSource;
	AudioSource loopSource;

	private void Awake()
	{
		if (Instance != null && Instance != this)
		{

			Destroy(gameObject);

		}

		Instance = this;

		oneshotSource = gameObject.AddComponent<AudioSource>();
		loopSource = gameObject.AddComponent<AudioSource>();

		loopSource.loop = true;
	}

	public void PlayCollect() => oneshotSource.PlayOneShot(collectclip);


}

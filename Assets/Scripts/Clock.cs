using UnityEngine;

public class Clock : MonoBehaviour
{

	AudioSource audio;

	private static Clock instance;

	private Clock ()
	{
	}

	void Start() {
		audio = GetComponent<AudioSource> ();
	}

	void Update() {
		Debug.Log (audio.time);
	}

	public Clock getInstance() {
		if (instance == null) {
			instance = new Clock ();
		} 
		return instance;
	}

	public float getPartialTick() {
		return 0.0F;
	}

}



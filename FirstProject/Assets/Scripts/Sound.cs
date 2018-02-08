using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]			// So that the array "sounds" shows in inspector
public class Sound {

	public string name;

	public AudioClip clip;

	[Range(0f, 10f)]				// Add a slider to inspector with range of 0 - 10
	public float volume;
	[Range(.1f, 3f)]
	public float pitch;

	[HideInInspector]
	public AudioSource source;

}

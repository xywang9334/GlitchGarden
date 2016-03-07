using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level) {
		AudioClip audio = levelMusicChangeArray[level];
		if (audio) {
			audioSource.clip = audio;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
	
	public void ChangeVolume (float volume) {
		audioSource.volume = volume;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Awake() {
		DontDestroyOnLoad(gameObject);
		
	}
}

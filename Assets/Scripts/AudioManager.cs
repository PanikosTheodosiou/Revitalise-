using UnityEngine;

[System.Serializable]
public class Sound{

    public string name;
    public AudioClip Clip;

    [Range(0f,3f)]
    public float volume = 0.7f;
    [Range(0f, 2f)] 
    public float pitch = 1f;

    [Range(0f,0.5f)] 
    public float randomVolume = 0.1f;
    public float randomPitch = 0.1f;

    private AudioSource source;

    public void SetSource(AudioSource _source)
    {
        source = _source;
        source.clip = Clip;
    }
    public void Play()
    {

        source.volume = volume * (1 + Random.Range(- randomVolume/  2f, randomVolume / 2f));
        source.pitch = pitch *(1 + Random.Range(-randomPitch / 2f, randomPitch / 2f));
        source.Play();
    }

}


public class AudioManager : MonoBehaviour {

        [SerializeField]
        Sound[] sounds;

    }
    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private AudioSource audioSource;
    public AudioClip boop;
    public float volume = 0.25f;

    float timer = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayAudioWithDelay());
    }

    // Update is called once per frame
    void Update()
    {
        // You can remove the PlayOneShot() call from the Update() method
    }

    private IEnumerator PlayAudioWithDelay()
    {
        while (true)
        {
            audioSource.PlayOneShot(boop, volume);
            yield return new WaitForSeconds(16f);
        }
    }
}

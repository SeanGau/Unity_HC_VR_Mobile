using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBase : MonoBehaviour
{
    public float speed = 3f;
    public AudioClip sound;
    public float volume = 1;
    public float delay = 0.1f;

    protected AudioSource aud;

    protected virtual void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    protected virtual IEnumerator Action()
    {
        yield return null;
    }

    public void StartAction()
    {
        StartCoroutine(Action());
    }
}

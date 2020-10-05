using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BucketMove : MonoBehaviour
{
    public float movingSpeed = 3f;
    public Transform targetPoint;
    public AudioClip sound;
    public float volume = 1;

    private AudioSource aud;

    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }
    IEnumerator ObjMove()
    {
        GetComponent<Collider>().enabled = false;
        Vector3 posA = transform.position;
        Vector3 posB = targetPoint.position;
        aud.PlayOneShot(sound, volume);
        while (posA != posB)
        {
            posA = Vector3.Lerp(posA, posB, 0.5f * Time.deltaTime * movingSpeed);
            transform.position = posA;
            yield return null;
        }
    }

    public void startMoving()
    {
        StartCoroutine(ObjMove());
    }
}

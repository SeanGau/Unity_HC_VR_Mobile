using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketMove : ObjectBase
{
    public Transform targetPoint;
    protected override IEnumerator Action()
    {
        GetComponent<Collider>().enabled = false;
        Vector3 posA = transform.position;
        Vector3 posB = targetPoint.position;
        aud.PlayOneShot(sound, volume);
        while (posA != posB)
        {
            posA = Vector3.Lerp(posA, posB, 0.5f * Time.deltaTime * speed);
            transform.position = posA;
            yield return null;
        }
    }
}

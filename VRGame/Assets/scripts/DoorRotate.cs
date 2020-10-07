using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRotate : ObjectBase
{
    public float targetAngle = 90f;

    protected override IEnumerator Action()
    {
        GetComponent<Collider>().enabled = false;
        aud.PlayOneShot(sound, volume);
        yield return new WaitForSeconds(delay);

        Quaternion angleA = transform.rotation;
        Quaternion angleB = Quaternion.Euler(0, targetAngle, 0);

        while(angleA != angleB)
        {
            angleA = Quaternion.Lerp(angleA, angleB, speed * Time.deltaTime);
            transform.rotation = angleA;
            yield return null;
        }
    }
}

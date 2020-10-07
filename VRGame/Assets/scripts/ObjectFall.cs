using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFall : ObjectBase
{
    private Rigidbody rig;

    protected override void Awake()
    {
        base.Awake();

        rig = GetComponent<Rigidbody>();
    }

    protected override IEnumerator Action()
    {


        aud.PlayOneShot(sound, volume);

        rig.useGravity = true;
        yield return new WaitForSeconds(delay);
        aud.enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Bullet : Bullet_Base
{
    [SerializeField] private GameObject explosion;

    protected void Start(){
        SoundManager.Instance.Sound(SoundManager.Instance.soundList[2], false, 1);
    }

    protected override void Update()
    {
        base.Update();
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
    }

    protected override void Hit_Event(){
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

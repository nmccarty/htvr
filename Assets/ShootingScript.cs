using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using VRTK;

[RequireComponent(typeof(AudioSource))]
public class ShootingScript : VRTK_InteractableObject
{
    public AudioClip shot;
    public AudioClip reload;
    public Rigidbody bullet;
    public float speed;
    public int ammo;
    AudioSource audio;
    string currentClip = "";
    int maxAmmo;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(shot, 0.7f);
        audio.Pause();
        currentClip = "shot";
        maxAmmo = ammo;
    }

    public void fireBullet() {
        ammo--;
        audio.PlayOneShot(shot, 1.0f);
        Rigidbody instantiatedProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
    }

    public override void StartUsing(GameObject usingObject)
    {
        fireBullet();
        Debug.Log("I was here");
    }

}

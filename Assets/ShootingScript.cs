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
	

	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyUp(KeyCode.R)) {
            audio.Stop();
            audio.PlayOneShot(reload, 1.0f);
            currentClip = "reload";
            ammo = maxAmmo;
        } else if (Input.GetKeyDown("space") && ammo != 0) {
            audio.Stop();
            audio.PlayOneShot(shot, 0.7f);
            currentClip = "shot";
            fireBullet();
        } else if (Input.GetKeyUp("space") || ammo == 0) {
            if (audio.isPlaying == true || currentClip == "shot") {
                audio.Stop();
            }
        } else {
            if (audio.isPlaying && currentClip == "shot") {
                audio.Stop();
            }
        }
	}

    public void fireBullet() {
        ammo--;
        Rigidbody instantiatedProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
        instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
    }

    public override void StartUsing(GameObject usingObject)
    {
        fireBullet();
        Debug.Log("I was here");
    }

}

using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float x = Random.Range(-100, 100)/100.0f;
        float y = Random.Range(-100, 100) / 100.0f;
        float z = Random.Range(-100, 100) / 100.0f;

        Vector3 p = new Vector3(x, y, z);
        gameObject.transform.position += p;
	}

    void OnCollisionEnter(Collision collision)
    {
        if(gameObject.tag == "Enemy(Clone)" && collision.gameObject.tag != "Enemy(Clone)")
            Destroy(gameObject);
    }
}

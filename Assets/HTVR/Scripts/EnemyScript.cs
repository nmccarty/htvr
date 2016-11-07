using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

    public int moveSpeed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(gameObject.name == "Enemy" || gameObject.name == "Enemy2")
        {
            return;
        }
        float x = Random.Range(0, 100) / (100000.0f / moveSpeed);
        float y = Random.Range(-100, 100) / (100000.0f / moveSpeed);
        float z = Random.Range(-100, 100) / (100000.0f / moveSpeed);

        Vector3 p = new Vector3(x, y, z);
        gameObject.transform.position += p;
	}

    void OnTriggerEnter(Collider collision)
    {
        //if (gameObject.tag == "Enemy(Clone)" && collision.gameObject.tag != "Enemy(Clone)")
        //{
        if(gameObject.name != "Enemy" || gameObject.name == "Enemy2")
        {
            Destroy(gameObject);
        }
           
        //}
    }
}

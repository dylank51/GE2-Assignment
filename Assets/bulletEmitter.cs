using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletEmitter : MonoBehaviour
{
	
	public GameObject bulletEmit;
	public GameObject bullet;
	public GameObject target;
	public float bulletForce;
	private float fireTime = 0f;
	private float fire = 3f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		fireTime += Time.deltaTime;
		if(fireTime > fire)
		{
			fireTime = 0;
			
			GameObject temporaryBulletHandler;
			temporaryBulletHandler = Instantiate (bullet, bulletEmit.transform.position, bulletEmit.transform.rotation) as GameObject;
			
			temporaryBulletHandler.transform.Rotate(Vector3.left*90);
			
			Rigidbody temporaryRigidbody;
			temporaryRigidbody = temporaryBulletHandler.GetComponent<Rigidbody>();
			
			temporaryRigidbody.AddForce(transform.forward * bulletForce);
			
			Destroy(temporaryBulletHandler, 10.0f);
		}
        
    }
}

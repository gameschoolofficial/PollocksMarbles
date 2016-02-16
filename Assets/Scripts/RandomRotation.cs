using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {
	
	bool noTarget= true;
	Quaternion qTo;
	float speed= 0.5f;
	float rotateSpeed= 0.5f;
	float timer= 0.0f;
	
	void  Start (){
		qTo = Quaternion.Euler(new Vector3(Random.Range(-20.0f, 20.0f), 0.0f, Random.Range(-20.0f, 20.0f)));
		
	}
	
	void  Update (){
		
		timer += Time.deltaTime;
		
		if(noTarget == true) {//when not targeting hero     
			if(timer > 3) { // timer resets at 2, allowing .5 s to do the rotating
				qTo = Quaternion.Euler(new Vector3(Random.Range(-20.0f, 20.0f), 0.0f, Random.Range(-20.0f, 20.0f)));  
				timer = 0.0f;
			}
			transform.rotation = Quaternion.Slerp(transform.rotation, qTo, Time.deltaTime * rotateSpeed);
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	}
}
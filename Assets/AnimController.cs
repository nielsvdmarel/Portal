using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class AnimController : MonoBehaviour
{
	private Animator anim;
	[SerializeField]
	private bool _isOpen;
	[SerializeField]
	int wait_time;
	
	void Start ()
	{
		anim = GetComponent<Animator>();
		anim.SetBool("Open", true);
		anim.SetBool("Closed",false);
		_isOpen = true;
		
		StartCoroutine (waiter());
	}
	
	
	void Update () 
	{
		
	}
	
	
	
	IEnumerator waiter()
	{
		wait_time = Random.Range (20,30);
		yield return new WaitForSeconds (wait_time);
		if (_isOpen == true)
		{
			_isOpen = false;
		}
		else
		{
			_isOpen = true;
		}
		checker();
		StartCoroutine (waiter());
	}

	void checker()
	{
		if(_isOpen == true)
		{
			anim.SetBool("Open", true);
			anim.SetBool("Closed",false);
		}
		
		if(_isOpen == false)
		{
			anim.SetBool("Open", false);
			anim.SetBool("Closed",true);
		}
	}
}




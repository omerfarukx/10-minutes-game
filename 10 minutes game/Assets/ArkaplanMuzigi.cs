using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanMuzigi : MonoBehaviour
{
	static bool SahnedeMuzikVar;
	// Use this for initialization
	void Awake()
	{
		if (!SahnedeMuzikVar)
		{
			GameObject.DontDestroyOnLoad(gameObject);
			SahnedeMuzikVar = true;
		}
		else
		{
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update()
	{

	}
}

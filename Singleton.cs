using UnityEngine;
using System.Collections;

/// <summary>
/// Singleton模版
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract class Singleton<T> where T : class, new()
{
	private static T _instance;

	public static T Instance
	{
		get
		{
			if (_instance == null)
				_instance = new T();
			return _instance;
		}
	}
}

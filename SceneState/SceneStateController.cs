using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 場景狀態控制者
/// </summary>
public class SceneStateController
{
	private ISceneState m_State;
	private bool m_bRunBegin = false;

	public SceneStateController()
	{ 
	}

	/// <summary>
	/// 設定狀態
	/// </summary>
	/// <param name="State"></param>
	/// <param name="LoadSceneName"></param>
	public void SetState(ISceneState State, string LoadSceneName)
	{
		//Debug.Log ("SetState:"+State.ToString());
		m_bRunBegin = false;

		// 載入場景
		LoadScene(LoadSceneName);

		// 通知前一個State結束
		if (m_State != null)
		{
			m_State.StateEnd();
		}

		// 設定
		m_State = State;
	}

	/// <summary>
	/// 載入場景
	/// </summary>
	/// <param name="LoadSceneName"></param>
	private void LoadScene(string LoadSceneName)
	{
		if (LoadSceneName == null || LoadSceneName.Length == 0)
		{
			return;
		}
		SceneManager.LoadScene(LoadSceneName);
		Debug.Log("SceneManager.LoadScene: " + LoadSceneName);
	}

	/// <summary>
	/// 更新
	/// </summary>
	public void StateUpdate()
	{
		// 是否還在載入		
		if (!SceneManager.GetActiveScene().isLoaded)
		{
			Debug.Log("還在載入: " + SceneManager.GetActiveScene().name);
			return;
		}

		// 通知新的State開始
		if (m_State != null && m_bRunBegin == false)
		{
			m_State.StateBegin();
			m_bRunBegin = true;
		}

		if (m_State != null)
		{
			m_State.StateUpdate();
		}
	}
}

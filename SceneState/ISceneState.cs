using UnityEngine;

/// <summary>
/// 場景狀態
/// </summary>
public class ISceneState
{
	/// <summary>
	/// 狀態名稱
	/// </summary>
	private string m_StateName = "ISceneState";
	public string StateName
	{
		get { return m_StateName; }
		set { m_StateName = value; }
	}

	/// <summary>
	/// 控制者
	/// </summary>
	protected SceneStateController m_Controller = null;

	/// <summary>
	/// 建構者
	/// </summary>
	/// <param name="Controller"></param>
	public ISceneState(SceneStateController Controller)
	{
		m_Controller = Controller;
	}

	/// <summary>
	/// 狀態開始
	/// </summary>
	public virtual void StateBegin()
	{ 
	}

	/// <summary>
	/// 狀態結束
	/// </summary>
	public virtual void StateEnd()
	{ 
	}

	/// <summary>
	/// 狀態更新
	/// </summary>
	public virtual void StateUpdate()
	{ 
	}

	/// <summary>
	/// 狀態名稱
	/// </summary>
	/// <returns></returns>
	public override string ToString()
	{
		return string.Format("[ISceneState: StateName={0}]", StateName);
	}
}


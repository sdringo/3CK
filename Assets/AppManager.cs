using UnityEngine;

public class AppManager : Entity
{
    private void OnApplicationQuit()
    {
        GameObject.Destroy(gameObject);
    }

    #region ILifeCycle Function
    public override void initialize()
    {
        Application.targetFrameRate = 60;

        GameObject.DontDestroyOnLoad(this.gameObject);

        //GameObject sceneMgr = SceneManager.instanceObject;
        //GameObject jobExecutor = JobExecutor.instanceObject;
    }

    public override void release()
    {

    }

    public override void update()
    {
		if (Input.GetKey(KeyCode.Escape))
			Application.Quit();
    }
    #endregion
}
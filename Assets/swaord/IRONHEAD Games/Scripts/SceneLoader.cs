using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{

    public static SceneLoader instance;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        StartCoroutine(Loader(sceneName));
    }

    IEnumerator Loader(string sceneName)
    {
        yield return new WaitForSeconds(3);

       AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        if(!asyncOperation.isDone)
        {
            yield return null;

        }
        yield return null;
    }
}

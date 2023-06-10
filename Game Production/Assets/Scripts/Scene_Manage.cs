using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Scene_Manage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Scene1()
    {
        SceneManager.LoadScene(1);
    }

    public void Scene2()
    {
        SceneManager.LoadScene(2);
    }

    public void Scene3()
    {
        SceneManager.LoadScene(3);
    }

    public void Scene4()
    {
        SceneManager.LoadScene(4);
    }


    public void Scene5()
    {
        SceneManager.LoadScene(5);
    }

    public void Scene6()
    {
        SceneManager.LoadScene(6);
    }

}

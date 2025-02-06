using UnityEngine;
using UnityEngine.SceneManagement;

namespace assigment 
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] 
        private int m_SceneIndex;
        
        void Start()
        {
            SceneManager.LoadScene(m_SceneIndex, LoadSceneMode.Single);
        }
    }
}

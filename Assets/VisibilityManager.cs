using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilityManager : MonoBehaviour
{
    [SerializeField] private GameObject[] m_disableWhileInGame = default;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableGameObjects()
    {
        SetMenuVisibility(false);
    }

    public void EnableGameObjects()
    {
        SetMenuVisibility(true);
    }
    
    private void SetMenuVisibility(bool areVisible)
    {
        foreach (GameObject go in m_disableWhileInGame)
        {
            go.SetActive(areVisible);
        }
    }

    public void DoTheThing()
    {
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0.5f, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStackKontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> blocklist =new List<GameObject>();
    private GameObject lastBlockObject;
    void Start()
    {
        UpdateLastBlockObject();
    }
    public void IncreaseBlockStack(GameObject _gameobject)
    {
        transform.position=new Vector3(transform.position.x,transform.position.y+2f,transform.position.z);
        _gameobject.transform.position=new Vector3(lastBlockObject.transform.position.x,lastBlockObject.transform.position.y-2f,lastBlockObject.transform.position.z);
        _gameobject.transform.SetParent(transform);
        blocklist.Add(_gameobject);
        UpdateLastBlockObject();
    }
    public void DecreaseBlock(GameObject _gameobject)
    {
        _gameobject.transform.parent=null;
        blocklist.Remove(_gameobject);
        UpdateLastBlockObject();
    }

    private void UpdateLastBlockObject()
    {
        lastBlockObject=blocklist[blocklist.Count - 1];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

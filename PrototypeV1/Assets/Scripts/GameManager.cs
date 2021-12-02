using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    // Start is called before the first frame update
    void Start()
    {
        if(instance==null){
            instance = this;
        }else{
            Destroy(gameObject);            
        }
        DontDestroyOnLoad(gameObject);
    }

}

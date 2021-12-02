using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{
    public static TouchManager instance = null;
    // Start is called before the first frame update
    void Start()
    {
        if(instance == null){
            instance = this;
        }else{
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
            Vector3 origin = new Vector3(Input.mousePosition.x, Input.mousePosition.y, -1f);
            RaycastHit hit;
        if(Physics.Raycast(origin, Vector3.forward, out hit, 10f)){
            if(Input.GetMouseButton(0)){
                Debug.Log("드래그 구현할거");
            }
            if(Input.GetMouseButtonUp(0)){
                Debug.Log("씬 전환 구현할거");
            }
        }     
    }
}

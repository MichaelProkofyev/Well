using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellController : SingletonComponent<WellController> {

    [SerializeField]
    GameObject wellBlock;

    public void PlayerPassedBlock(Transform blockT) {

        Vector3 newPostion = blockT.position - Vector3.up * 20f;
        print(newPostion.y);
        GameObject wellBlockClone = Instantiate(wellBlock, newPostion, Quaternion.identity) as GameObject;
        Color randomColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        foreach (var blockPart in GetComponentsInChildren<Renderer>()) {
            blockPart.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", randomColor);

        }

        Destroy(blockT.gameObject, 5f);
    }

    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using VivoxUnity;

public class GameManager : MonoBehaviour {
    //Client vivox_client = null;
    UDP udp;

    private void Awake() {
        DontDestroyOnLoad(this);
        udp = gameObject.GetComponent<UDP>();
    }

	// Start is called before the first frame update
	void Start() {
        
	}

	// Update is called once per frame
	void Update() { 
        string[] packets = udp.getUDPPackets();

		foreach (string packet in packets) {
			if (packet == "") continue;

			// 패킷 라인은 명령문으로 이루어지며, 명령문은 반드시 다음의 규칙을 따른다.
			// 명령어: 명령 오브젝트ID 추가_인수
			// 오브젝트ID: 씬내에서 움직일 오브젝트ID
			// 추가_인수: 명령어에 따라 필요한 추가 인수
		}
	}
}

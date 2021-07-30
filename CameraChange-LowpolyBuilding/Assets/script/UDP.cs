using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;

public class UDP : MonoBehaviour {
	// 노드와 달리 수신 확인을 위해 직접 스레드를 구현해서 구동해야 함
	Thread receiveThread;
	// upd 클라
	UdpClient receiveClient, sendClient;

	// 서버 주소
    // 로컬 호스트
	public string serverIP = "127.0.0.1";

    // 서버 포트
	public int serverPORT = 5500;
    // 전송용 포트
	public int sendPORT = 5600;
    // 수신용 포트
	public int receivePORT = 5700;

	public string lastReceivedUDPPacket = "";
	public string allReceivedUDPPackets = ""; // clean up this from time to time!

	private void Awake() {
		DontDestroyOnLoad(this);
	}

	void Start() {
		receiveClient = new UdpClient(receivePORT);
		receiveClient.Connect(serverIP, serverPORT);
		sendClient = new UdpClient(sendPORT);
		sendClient.Connect(serverIP, serverPORT);

		receiveThread = new Thread(
			new ThreadStart(ReceiveData)
		);
		receiveThread.IsBackground = true;
		receiveThread.Start();

        //test
		UDPTest();
	}

	// receive thread
    // 백그라운드 스레드에서 지속적인 수신이 이루어짐
	private void ReceiveData() {
		while (true) {
			try {
				// Bytes empfangen.
				IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
				byte[] data = receiveClient.Receive(ref anyIP);

				// Bytes mit der UTF8-Kodierung in das Textformat kodieren.
				string text = Encoding.UTF8.GetString(data);

				// Den abgerufenen Text anzeigen.
				Debug.Log(">> " + text);

				// latest UDPpacket
				lastReceivedUDPPacket = text;

				// ....
				allReceivedUDPPackets += '\n' + text;

			} catch (Exception err) {
				Debug.Log(err.ToString());
			}
		}
	}

    // 데이터 전송
    // Action: void Func(void) 함수를 callBack 인수로 받아 예외 발생 시 실행시킴.
	public void SendData(string data, Action onException) {
		try {
			byte[] sendBytes = Encoding.UTF8.GetBytes(data);
			sendClient.Send(sendBytes, sendBytes.Length);
		} catch (Exception e) {
			Debug.Log(e.ToString());
			onException();
		}
	}

	// getLatestUDPPacket
	// cleans up the rest
	public string getLatestUDPPacket() {
		allReceivedUDPPackets = "";
		return lastReceivedUDPPacket;
	}

	public string[] getUDPPackets() {
		return allReceivedUDPPackets.Split('\n');
	}

    public void resetUDPPackets() {
        allReceivedUDPPackets = "";
    }





	#region testing

	void onException() {
		Debug.Log("exception");
	}

	void UDPTest() {
		SendData("Hello, from the client", onException);
	}

    #endregion
}

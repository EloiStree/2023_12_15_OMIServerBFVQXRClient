using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class OMISPushToUDPMono : MonoBehaviour
{
    public string m_ip="192.168.1.250";
    public int m_port=2571;
     UdpClient m_udpClient;

    public Queue<byte[]> m_toSendByte = new Queue<byte[]>();
  

    private void Awake()
    {
        m_udpClient = new UdpClient(m_ip, m_port);
    }

    private void Update()
    {
        while (m_toSendByte.Count > 0) {
            byte[] b = m_toSendByte.Dequeue();
            
           
            m_udpClient.Send(b, b.Length);
        }
    }
    public void PushTextUTF8(string text) {

        if (text == null || text.Length < 1)
            return;
       
              byte[] data = Encoding.UTF8.GetBytes(text);
            m_toSendByte.Enqueue(data);

    }
    public void PushBytesAsRaw(byte[] bytes) {

        if (bytes == null || bytes.Length <1)
            return;
         m_toSendByte.Enqueue(bytes);

    }
    
}

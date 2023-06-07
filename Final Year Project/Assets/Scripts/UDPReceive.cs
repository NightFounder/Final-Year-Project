using UnityEngine;
using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine.SceneManagement;

public class UDPReceive : MonoBehaviour
{
 
    Thread receiveThread;
    UdpClient client; 
    public int port = 3030;
    public bool startRecieving = true;
    public bool printToConsole = false;
    public string data;



    public void Awake()
    {
            receiveThread = new Thread(new ThreadStart(ReceiveData));
            receiveThread.IsBackground = true;
            receiveThread.Start();
            print("Awake is called");

            
    }



    // receive thread
    private void ReceiveData()
    {
        client = new UdpClient(port);
        while (startRecieving)
        {
            
            try
            {
                IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
                byte[] dataByte = client.Receive(ref anyIP);
                data = Encoding.UTF8.GetString(dataByte);

                if (printToConsole) 
                { 
                    print(data); 
                }
            }
            //catch(ThreadAbortException abortException)
            //{
             //   client.Close();
             //   print("THREAD ABORT");
             //   startRecieving = false;
            //}

            catch (Exception err)
            {
                print(err.ToString());
                print("error");
            }
        }
    }



    public void OnDestroy()
    {
        
        print("On destroy");
        client.Close();
        receiveThread.Abort();
    }






}

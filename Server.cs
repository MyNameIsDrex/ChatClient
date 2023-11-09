using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class ChatServer
{
    private static List<ClientHandler> clients = new List<ClientHandler>();
    private static TcpListener server;

    static void Server()
    {
        server = new TcpListener(IPAddress.Any, 12345);
        server.Start();
        Console.WriteLine("Server is running...");

        while (true)
        {
            TcpClient client = server.AcceptTcpClient();
            ClientHandler clientHandler = new ClientHandler(client);
            clients.Add(clientHandler);

            Thread clientThread = new Thread(clientHandler.HandleClient);
            clientThread.Start();
        }
    }

    public static void BroadcastMessage(string message, ClientHandler sender)
    {
        foreach (ClientHandler client in clients)
        {
            if (client != sender)
            {
                client.SendMessage(message);
            }
        }
    }

    public static void RemoveClient(ClientHandler client)
    {
        clients.Remove(client);
    }
}

class ClientHandler
{
    private TcpClient client;
    private StreamReader reader;
    private StreamWriter writer;
    private string name;

    public ClientHandler(TcpClient client)
    {
        this.client = client;
        NetworkStream stream = client.GetStream();
        reader = new StreamReader(stream, Encoding.UTF8);
        writer = new StreamWriter(stream, Encoding.UTF8);
        Console.WriteLine("Client connected from: " + ((IPEndPoint)client.Client.RemoteEndPoint).Address);
    }

    public void HandleClient()
    {
        writer.WriteLine("Welcome to the chat! Enter your name: ");
        writer.Flush();

        name = reader.ReadLine();
        Console.WriteLine("User '" + name + "' has joined the chat.");

        while (true)
        {
            try
            {
                string message = reader.ReadLine();
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine("User '" + name + "' has left the chat.");
                    ChatServer.RemoveClient(this);
                    break;
                }
                Console.WriteLine(name + ": " + message);
                ChatServer.BroadcastMessage(name + ": " + message, this);
            }
            catch (Exception)
            {
                Console.WriteLine("User '" + name + "' has left the chat.");
                ChatServer.RemoveClient(this);
                break;
            }
        }

        reader.Close();
        writer.Close();
        client.Close();
    }

    public void SendMessage(string message)
    {
        writer.WriteLine(message);
        writer.Flush();
    }
}

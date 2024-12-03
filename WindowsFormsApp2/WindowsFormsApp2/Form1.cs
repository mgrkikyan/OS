using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private Mutex mutex = new Mutex();
    private Queue<string> sharedQueue = new Queue<string>();
    private Thread writer1, writer2, reader1, reader2;
    private bool isRunning = true;

    public Form1()
    {
        InitializeComponent();
        CheckForIllegalCrossThreadCalls = false;

        // Добавьте обработчики событий
        txtWriter1Input.KeyPress += txtWriter1Input_KeyPress;
        txtWriter2Input.KeyPress += txtWriter2Input_KeyPress;
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        writer1 = new Thread(Writer1Process);
        writer2 = new Thread(Writer2Process);
        reader1 = new Thread(Reader1Process);
        reader2 = new Thread(Reader2Process);

        writer1.Start();
        writer2.Start();
        reader1.Start();
        reader2.Start();
    }

    private void txtWriter1Input_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            string dataToWrite = txtWriter1Input.Text;
            if (!string.IsNullOrEmpty(dataToWrite))
            {
                mutex.WaitOne();
                sharedQueue.Enqueue($"Writer1: {dataToWrite}");
                mutex.ReleaseMutex();

                txtWriter1Log.AppendText($"Записано: {dataToWrite}\r\n");
                txtWriter1Input.Clear();
            }
            e.Handled = true; // Предотвращаем звуковой сигнал при нажатии Enter
        }
    }

    private void txtWriter2Input_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            string dataToWrite = txtWriter2Input.Text;
            if (!string.IsNullOrEmpty(dataToWrite))
            {
                mutex.WaitOne();
                sharedQueue.Enqueue($"Writer2: {dataToWrite}");
                mutex.ReleaseMutex();

                txtWriter2Log.AppendText($"Записано: {dataToWrite}\r\n");
                txtWriter2Input.Clear();
            }
            e.Handled = true;
        }
    }

    // Измените методы Writer1Process и Writer2Process
    private void Writer1Process()
    {
        while (isRunning)
        {
            Thread.Sleep(100); // Просто держим поток активным
        }
    }

    private void Writer2Process()
    {
        while (isRunning)
        {
            Thread.Sleep(100);
        }
    }

    private void Reader1Process()
    {
        while (isRunning)
        {
            mutex.WaitOne();
            if (sharedQueue.Count > 0)
            {
                string dataRead = sharedQueue.Dequeue();
                txtReader1Log.AppendText($"Прочитано: {dataRead}\r\n");
            }
            mutex.ReleaseMutex();
            Thread.Sleep(1000);
        }
    }

    private void Reader2Process()
    {
        while (isRunning)
        {
            mutex.WaitOne();
            if (sharedQueue.Count > 0)
            {
                string dataRead = sharedQueue.Dequeue();
                txtReader2Log.AppendText($"Прочитано: {dataRead}\r\n");
            }
            mutex.ReleaseMutex();
            Thread.Sleep(1000);
        }
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        isRunning = false;
    }


}
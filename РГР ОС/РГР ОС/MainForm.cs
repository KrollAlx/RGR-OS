using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace РГР_ОС
{
    public partial class MainForm : Form
    {
        private Random random;
        private int bufferSize;
        private Queue<int> buffer;
        private Thread produserThread;
        private Thread consumerThread;
        private Semaphore semEmpty;
        private Semaphore semFull;
        private Semaphore semMutex;
        private delegate void ShowBufferDelegate();
        private delegate void ShowProducerActionDelegate(int Value);
        private delegate void ShowConsumerActionDelegate(int Value);
        public MainForm()
        {
            InitializeComponent();         
        }        
        private void StartButton_Click(object sender, EventArgs e)
        {
            ProducerListView.Items.Clear();
            ConsumerListView.Items.Clear();
            bufferSize = (int)BufferSizeNumericUpDown.Value;
            random = new Random();
            buffer = new Queue<int>(bufferSize);
            semEmpty = new Semaphore(bufferSize, bufferSize);
            semFull = new Semaphore(0, bufferSize);
            semMutex = new Semaphore(1, 1);
            produserThread = new Thread(Producer);
            consumerThread = new Thread(Consumer);
            produserThread.Start();
            consumerThread.Start();
        }
        private void Producer()
        {
            int Value;
            while (true)
            {
                Value = random.Next(1, 100);
                semEmpty.WaitOne();
                semMutex.WaitOne();
                buffer.Enqueue(Value);
                ProducerListView.BeginInvoke(new ShowProducerActionDelegate(ShowProducerAction),Value);
                BufferLabel.BeginInvoke(new ShowBufferDelegate(ShowBuffer));                
                semMutex.Release();
                semFull.Release();
                Thread.Sleep(random.Next(500, 2000));
            }
        }
        private void Consumer()
        {
            int Value;
            while (true)
            {
                semFull.WaitOne();
                semMutex.WaitOne();
                Value = buffer.Dequeue();
                ConsumerListView.BeginInvoke(new ShowConsumerActionDelegate(ShowConsumerAction), Value);             
                BufferLabel.BeginInvoke(new ShowBufferDelegate(ShowBuffer));
                semMutex.Release();
                semEmpty.Release();
                Thread.Sleep(random.Next(500, 2000));
            }
        }
        private void ShowBuffer()
        {
            BufferLabel.Text = "Содержимое буфера: ";
            foreach(int item in buffer)
            {
                BufferLabel.Text += $"{item.ToString()} ";
            }
        }
        private void ShowProducerAction(int Value)
        {
            ProducerListView.Items.Add($"Записано в буфер: {Value.ToString()}");
        }
        private void ShowConsumerAction(int Value)
        {
            ConsumerListView.Items.Add($"Прочитано из буфера: {Value.ToString()}");
        }        
        private void StopButton_Click(object sender, EventArgs e)
        {
            produserThread.Abort();
            consumerThread.Abort();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (produserThread != null) 
            {
                produserThread.Abort();
            }
            if (consumerThread != null)
            {
                consumerThread.Abort();
            }            
        }
    }
}

using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace BackgroundWorker_Sample
{
    public partial class MainWindow : Window
    {
        BackgroundWorker worker;

        public MainWindow()
        {
            InitializeComponent();
            CancelButton.IsEnabled = false;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();

            StartButton.IsEnabled = false;
            CancelButton.IsEnabled = true;

            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            int maxItems = 50;
            ProgressBar1.Minimum = 1;
            ProgressBar1.Maximum = 100;

            StatusTextBox.Text = "Starting...";
            worker.RunWorkerAsync(maxItems);
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            int? maxItems = e.Argument as int?;
            for (int i = 1; i <= maxItems.GetValueOrDefault(); ++i)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }

                Thread.Sleep(200);
                worker.ReportProgress(i);

                //item added
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            worker.CancelAsync();
        }

      

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            double percent = (e.ProgressPercentage * 100) / 50;

            ProgressBar1.Value = Math.Round(percent, 0);

            ListBox1.Items.Add(new ListBoxItem { Content = e.ProgressPercentage + " item added" });
            StatusTextBox.Text = Math.Round(percent, 0) + "% percent completed";
        }




        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                StatusTextBox.Text = "Cancelled";
            }
            else
            {
                StatusTextBox.Text = "Completed";
            }
            StartButton.IsEnabled = true;
            CancelButton.IsEnabled = false;
        }
    }
}

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp56;

namespace FaceRecognition
{
    public partial class FaceInsertionForm : Form
    {
        public FaceInsertionForm()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        public string suspect;
        private void FaceInsertionForm_Load(object sender, EventArgs e)
        {
            Capture capture = new Capture();
            capture.Start();
            capture.ImageGrabbed += (a, b) =>
            {
                var image = capture.RetrieveBgrFrame();
                var grayimage = image.Convert<Gray, byte>();
                var normalimage = image;
                HaarCascade haarface = new HaarCascade("haarcascade_frontalface_alt2.xml");
                MCvAvgComp[][] Faces = grayimage.DetectHaarCascade(haarface, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
                foreach (MCvAvgComp face in Faces[0])
                {
                    var onlyFaceBGR = normalimage.Copy(face.rect).Convert<Bgr, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    var onlyFace = grayimage.Copy(face.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    pictureBox2.Image = onlyFace.ToBitmap();
                    if (train != null)
                        if (train.IsTrained)
                        {
                            string name = train.Recognise(onlyFace);
                            int match_value = (int)train.Get_Eigen_Distance;
                            Color nameColor = Color.Blue;
                            Color drawColor = Color.Red;
                            if (name == suspect)
                            {
                                drawColor = Color.DarkRed;
                                nameColor = Color.Red;
                                label4.Text = "Suspect Detected";
                                pictureBox1.Image = onlyFaceBGR.ToBitmap();
                            }
                            image.Draw(name + " ", ref font, new Point(face.rect.X - 2, face.rect.Y - 2), new Bgr(nameColor));
                        }
                    image.Draw(face.rect, new Bgr(Color.LightGreen), 2);
                }
                pictureBoxCam.Image = image.ToBitmap();
            };
        }
        BusinessRecognition recognition = new BusinessRecognition("C://", "Faces", "face.xml");
        Classifier_Train train = new Classifier_Train("C://", "Faces", "face.xml");

        private void bttnDeleteAllFaces_Click(object sender, EventArgs e)
        {
            recognition.DeleteTrains();
            MessageBox.Show("Deletion Completed");
        }
        private async void bttnAddFace2_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    if (!recognition.SaveTrainingData(pictureBox2.Image, txtBoxName.Text)) MessageBox.Show("Error", "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.Sleep(100);
                    label2.Text = (i + 1) + " number of profiles";
                }
                recognition = null;
                train = null;
                recognition = new BusinessRecognition("C://", "Faces", "face.xml");
                train = new Classifier_Train("C://", "Faces", "face.xml");
            });
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            suspect = textBox1.Text;
        }
    }
}

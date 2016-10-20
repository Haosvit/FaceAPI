using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FaceAPI
{
	public partial class Form1 : Form
	{
		private string _imgPath;
		private Graphics _graphic;
		private Pen _pen;
		private List<RootObject> _faceInfoList;
		private int _circleSize;
		private string _returnedJson;
		public Form1()
		{
			InitializeComponent();
			_graphic = panel1.CreateGraphics();
			_graphic.Clear(Color.White);
			_pen = new Pen(new SolidBrush(Color.OrangeRed));

			backgroundWorker1.DoWork += OnSendRequest;
			backgroundWorker1.RunWorkerCompleted += OnResultReceived;
		}

		private void btnDetect_Click(object sender, EventArgs e)
		{
			backgroundWorker1.RunWorkerAsync();
		}

		public string getJSON()
		{
			try
			{
				var request =
					(HttpWebRequest) WebRequest.Create("https://api.projectoxford.ai/face/v1.0/detect?" +
					                                   "returnFaceId=true" +
					                                   "&returnFaceLandmarks=true" +
													   "&returnFaceAttributes=age,gender,smile");
				
				//var postData = "{\"url\":\"http://nguoinoitieng.vn/images/item/tieu-su-ca-si-my-tam.JPG\"}";

				var imgBinary = File.ReadAllBytes(_imgPath);

				request.Method = "POST";
				request.ContentType = "application/octet-stream";
				request.ContentLength = imgBinary.Length;
				request.Host = "api.projectoxford.ai";
				request.Headers.Add("Ocp-Apim-Subscription-Key", "1c056c36ece84f14a0619803ee4f0ceb");

				using (var stream = request.GetRequestStream())
				{
					stream.Write(imgBinary, 0, imgBinary.Length);
				}

				var response = (HttpWebResponse) request.GetResponse();

				var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
				return responseString;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			} 

			return "";
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				_imgPath = openFileDialog1.FileName;
				label1.Text = _imgPath;
				DrawImageOnPanel();
			}
		}

		private void UpdateFaceInfo()
		{
			if (_faceInfoList.Count > 0)
			{
				_lblGender.Text = _faceInfoList[0].faceAttributes.gender;
				_lblAge.Text = _faceInfoList[0].faceAttributes.age.ToString();
			}
		}

		private void DrawImageOnPanel()
		{
			var image = Image.FromFile(_imgPath);
			_graphic.Clear(Color.White);
			_graphic.DrawImage(image, 0, 0, image.Width, image.Height);
			richTextBox1.Clear();
		}

		private void DrawFacePointsOnPanel()
		{
			foreach (RootObject face in _faceInfoList)
			{
				var faceRect = new Rectangle(face.faceRectangle.left, face.faceRectangle.top, face.faceRectangle.width, face.faceRectangle.height);
				_circleSize = faceRect.Width/20;
				var leftPupil = new Point((int)face.faceLandmarks.pupilLeft.x, (int)face.faceLandmarks.pupilLeft.y);
				var rightPupil = new Point((int)face.faceLandmarks.pupilRight.x, (int)face.faceLandmarks.pupilRight.y);
				var leftMouth = new Point((int)face.faceLandmarks.mouthLeft.x, (int)face.faceLandmarks.mouthLeft.y);
				var rightMouth = new Point((int)face.faceLandmarks.mouthRight.x, (int)face.faceLandmarks.mouthRight.y);
				var noseRoot = new Point((int)face.faceLandmarks.noseTip.x, (int)face.faceLandmarks.noseTip.y);
				_graphic.DrawRectangle(_pen, faceRect);
				_graphic.DrawEllipse(_pen, new Rectangle(leftPupil, new Size(_circleSize, _circleSize)));
				_graphic.DrawEllipse(_pen, new Rectangle(rightPupil, new Size(_circleSize, _circleSize)));
				_graphic.DrawEllipse(_pen, new Rectangle(leftMouth, new Size(_circleSize, _circleSize)));
				_graphic.DrawEllipse(_pen, new Rectangle(rightMouth, new Size(_circleSize, _circleSize)));
				_graphic.DrawEllipse(_pen, new Rectangle(noseRoot, new Size(_circleSize, _circleSize)));
			}
		}
		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			_graphic = panel1.CreateGraphics();
			_graphic.Clear(Color.White);
		}


		private void OnSendRequest(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			_returnedJson = getJSON();
		}

		private void OnResultReceived(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			richTextBox1.Text = _returnedJson;
			_faceInfoList = new List<RootObject>();
			_faceInfoList = JsonConvert.DeserializeObject<List<RootObject>>(_returnedJson);
			DrawFacePointsOnPanel();
			UpdateFaceInfo();
		}

	}
}

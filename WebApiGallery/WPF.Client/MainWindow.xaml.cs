using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Client.Models.CarValidation;

namespace WPF.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           //Thread.Sleep(3000);
                                   
            // створення запиту за допомогою URL-адреси, на яку можна отримати публікацію
            WebRequest request = WebRequest.Create("http://localhost:5000/api/cars/add");
     
            // встановлення для властивості метод запиту POST
            request.Method = "POST";

            // створення даних POST і перетворення їх у байтовий масив
            string postData = JsonConvert.SerializeObject(new
            {
                //Mark = "Ford",
                //Model = "Биток із США",
                Year = 2020,
                Fuel = "Брикет РУФ",
                Сapacity = 5.7F,
                Image = "2021-Ford-Th999underbird-Rebord.jpg"
            });
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/json";
            // Set the ContentLength property of the WebRequest.
            //request.ContentLength = byteArray.Length;

            // отримання потоку запитів
            Stream dataStream = request.GetRequestStream();
            
            // запис данних до потоку запитів
            dataStream.Write(byteArray, 0, byteArray.Length);
            // Close the Stream object.
            dataStream.Close();

            try
            {
                // отримання відповіді від запиту
                WebResponse response = request.GetResponse();
                // відображення стану
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // отримання потоку, який має дані отримані з сервера
                // блок який використовується, забезпечує автоматичне закриття потоку
                using (dataStream = response.GetResponseStream())
                {
                    // Відкриття потоку за допомогою StreamReader
                    StreamReader reader = new StreamReader(dataStream);
                    
                    // читання данних з сервера
                    string responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    Console.WriteLine(responseFromServer);
                }

                // Close the response.
                response.Close();
            }

            catch (WebException e)
            {
               // виняток дає можливість дізнатися причину помилки
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    
                    MessageBox.Show("Error code: " + httpResponse.StatusCode);
                    using (Stream data = response.GetResponseStream())
                    using (var reader = new StreamReader(data))
                    {
                        string text = reader.ReadToEnd();
                        var errors = JsonConvert.DeserializeObject<AddCarValidation>(text);
                        MessageBox.Show(text);
                        MessageBox.Show(errors.Errors.Mark[0]);
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            InitializeComponent();
        }
    }
}

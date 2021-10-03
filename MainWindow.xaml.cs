using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonDecode_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputText.Text) && !outputText.Text.Contains(inputText.Text))
            {
                outputText.Text = Decodage.Decode(inputText.Text, inputKey.Text, inputVector.Text);
                inputText.Clear();
                inputKey.Clear();
                inputVector.Clear();
            }
        }
        
        private void ButtonEncode_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(inputTextC.Text) && !outputTextC.Text.Contains(inputTextC.Text))
            {
                outputTextC.Text = Encodage.Encode(inputTextC.Text, inputKeyC.Text, inputVectorC.Text);
                inputTextC.Clear();
                inputKeyC.Clear();
                inputVectorC.Clear();
            }
        }
    }

    internal static class Decodage
    {
        public static string Decode(string inputText, string inputKey, string inputVect)
        {
            try
            {
                byte[] key = Encoding.UTF8.GetBytes(inputKey);
                byte[] vect = Encoding.UTF8.GetBytes(inputVect);
            
                RijndaelManaged rijndael = new RijndaelManaged();
            
                ICryptoTransform decryptor = rijndael.CreateDecryptor(key, vect);
                
                MemoryStream msDecrypt = new MemoryStream();
                CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Write);
                StreamWriter swDecrypt = new StreamWriter(csDecrypt);
                
                swDecrypt.Write(inputText);
                
                byte[] decodeText = msDecrypt.ToArray();
                
                msDecrypt.Close();
                csDecrypt.Close();
                swDecrypt.Close();
            
                return Convert.ToBase64String(decodeText);
            }
            catch (Exception e)
            {
                return "Decryption failed";
            }
        }
    }

    internal static class Encodage
    {
        public static string Encode(string inputText, string inputKey, string inputVect)
        {
            try
            {
                byte[] key = Encoding.UTF8.GetBytes(inputKey);
                byte[] vect = Encoding.UTF8.GetBytes(inputVect);
            
                RijndaelManaged rijndael = new RijndaelManaged();
            
                ICryptoTransform encryptor = rijndael.CreateEncryptor(key, vect);
                
                MemoryStream msEncrypt = new MemoryStream();
                CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                StreamWriter swEncrypt = new StreamWriter(csEncrypt);
                
                swEncrypt.Write(inputText);
                
                byte[] encodeText = msEncrypt.ToArray();
                
                msEncrypt.Close();
                csEncrypt.Close();
                swEncrypt.Close();
            
                return Convert.ToBase64String(encodeText);
            }
            catch (Exception e)
            {
                return "Encryption failed";
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace traductor
{
    public partial class Form1 : Form
    {
        //Estas líneas de código declaran variables relacionadas con la traducción utilizando la API de Google Translate
        GoogleTranslateApi.Language source;
        GoogleTranslateApi.Language target;
        GoogleTranslateApi.GoogleTranslator translate;

        //Sirve para habilitar la síntesis de voz en una aplicación.
        private SpeechSynthesizer synthesizer;

        //Sirve para mapear un nombre de idioma legible por humanos a su código de idioma correspondiente.
        private string GetLanguageCode(string languageName)
        {
            //Es una implementacion switch (interruptor) que toma un nombre de idioma (languageName) como entrada y devuelve el código de idioma correspondiente.
            switch (languageName) // Switch = Utilizada para realizar una selección condicional entre múltiples opciones o casos.
            {
                case "Portuguese":
                    return "pt";
                case "English":
                    return "en";
                case "Spanish":
                    return "es";
                case "Russian":
                    return "ru";
                case "French":
                    return "fr";
                case "German":
                    return "de";
                case "Swedish":
                    return "sv";
                case "Italian":
                    return "it";
                case "Japanese":
                    return "ja";
                case "Chinese":
                    return "zh";
                default:
                    // En caso de que no se encuentre el idioma, puedes manejarlo de la forma que prefieras.
                    // En este ejemplo, se devolverá una cadena vacía.
                    return "";
            }
        }

        public Form1()
        {
            InitializeComponent();
            //Sirve para preparar tu aplicación para que pueda generar voz a partir de texto.
            synthesizer = new SpeechSynthesizer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Definir idiomas 
            source = GoogleTranslateApi.Language.Parse("es");
            target = GoogleTranslateApi.Language.Parse("en");        

            // Declarar e inicializar Traductor
            translate = new GoogleTranslateApi.GoogleTranslator(
                source,
                target
            );

            // Llena el ComboBox de idioma fuente
            cmbSourceLanguage.Items.Add("Spanish");
            cmbSourceLanguage.Items.Add("Portuguese"); 
            cmbSourceLanguage.Items.Add("English");
            cmbSourceLanguage.Items.Add("Russian");
            cmbSourceLanguage.Items.Add("French");
            cmbSourceLanguage.Items.Add("German");
            cmbSourceLanguage.Items.Add("Swedish");
            cmbSourceLanguage.Items.Add("Italian");
            cmbSourceLanguage.Items.Add("Japanese");
            cmbSourceLanguage.Items.Add("Chinese");

            // Llena el ComboBox de idioma de destino
            cmbTargetLanguage.Items.Add("Portuguese");
            cmbTargetLanguage.Items.Add("Spanish");
            cmbTargetLanguage.Items.Add("English");
            cmbTargetLanguage.Items.Add("Russian");
            cmbTargetLanguage.Items.Add("French");
            cmbTargetLanguage.Items.Add("German");
            cmbTargetLanguage.Items.Add("Swedish");
            cmbTargetLanguage.Items.Add("Italian");
            cmbTargetLanguage.Items.Add("Japanese");
            cmbTargetLanguage.Items.Add("Chinese");

            // Establece una selección inicial si lo deseas
            cmbSourceLanguage.SelectedIndex = 0;
            cmbTargetLanguage.SelectedIndex = 1;
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            // Sirve para obtener y almacenar información introducida por el usuario
            string textSource = txtSource.Text;
            string selectedSourceLanguage = cmbSourceLanguage.SelectedItem.ToString();
            string selectedTargetLanguage = cmbTargetLanguage.SelectedItem.ToString();

            // Convierte los nombres de idiomas a códigos de idioma, por ejemplo, "Español" a "es".
            GoogleTranslateApi.Language sourceLanguage = GoogleTranslateApi.Language.Parse(GetLanguageCode(selectedSourceLanguage));
            GoogleTranslateApi.Language targetLanguage = GoogleTranslateApi.Language.Parse(GetLanguageCode(selectedTargetLanguage));

            // Inicializa el traductor con los idiomas seleccionados
            translate = new GoogleTranslateApi.GoogleTranslator(sourceLanguage, targetLanguage);

            // Permite a los usuarios ingresar texto en un idioma, traducir ese texto a otro idioma y mostrar la traducción en la interfaz de usuario.
            string textTarget = translate.Text(textSource);
            txtTarget.Text = textTarget;
        }

        private void ReadSource_Click(object sender, EventArgs e)
        {
            // Habilita la síntesis de voz con el propósito de leer en voz alta el contenido de un control de caja de texto.
            string textToRead = txtSource.Text;
            synthesizer.SpeakAsync(textToRead);
        }

        private void ReadTarget_Click(object sender, EventArgs e)
        {
            // Habilita la síntesis de voz con el propósito de leer en voz alta el contenido de un control de caja de texto.
            string textToRead = txtTarget.Text;
            synthesizer.SpeakAsync(textToRead);
        }
    }
}
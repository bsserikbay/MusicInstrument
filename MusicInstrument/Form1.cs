using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace MusicInstrument
{
    public partial class Form1 : Form
    {
        SignalGenerator sine = new SignalGenerator()
        {
            Type = SignalGeneratorType.Sin,
            Gain = 0.2,
            Frequency = 600
        };
        public Form1()
        {
            InitializeComponent();

            var player = new WaveOutEvent();
            player.Init(sine);

            MouseDown += (s, e) => player.Play();
            MouseUp += (s, e) => player.Stop();
        }
    }
}
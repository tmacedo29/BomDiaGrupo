namespace BomDiaGrupo;

public partial class MainPage : ContentPage
{
  //---------------------------------------------------------------------------------------------------

  List<String> frases = new List<string>();
  string? fraseGerada = null;

  //---------------------------------------------------------------------------------------------------

	public MainPage()
	{
		InitializeComponent();

    frases.Add("Bom dia, família querida! Que este dia seja repleto de alegrias e conquistas para todos nós.");
    frases.Add("Que a luz do dia de hoje ilumine nossos corações e traga muita paz. Bom dia, família!");
    frases.Add("Bom dia, amores da minha vida! Que cada momento seja uma oportunidade de fazer alguém feliz.");
    frases.Add("Desejo a todos um dia abençoado, cheio de amor e realizações. Bom dia, família linda!");
    frases.Add("Que cada manhã seja uma nova chance de sermos melhores. Bom dia, queridos!");
    frases.Add("Bom dia! Que a felicidade nos encontre em cada passo que dermos hoje.");
    frases.Add("Que a alegria esteja presente em cada sorriso compartilhado nesta manhã. Bom dia, família amada!");
    frases.Add("Bom dia para todos! Que este dia seja repleto de momentos especiais e sorrisos sinceros.");
    frases.Add("Que a energia positiva deste novo dia nos inspire a alcançar nossos sonhos. Bom dia, pessoal!");
    frases.Add("Que a paz do Senhor esteja conosco nesta manhã abençoada. Bom dia, família abençoada!");
    frases.Add("Desejo a vocês um dia maravilhoso, cheio de amor e gratidão. Bom dia, queridos!");
    frases.Add("Que a serenidade do amanhecer nos acompanhe ao longo do dia. Bom dia, família querida!");
    frases.Add("Bom dia! Que cada instante seja uma oportunidade de fortalecer nossos laços familiares.");
    frases.Add("Que a positividade e a esperança guiem nossos passos hoje. Bom dia, amores!");
    frases.Add("Que a alegria contagie cada membro desta incrível família. Bom dia a todos!");
    frases.Add("Bom dia, pessoal! Que as bênçãos de Deus nos envolvam e nos protejam durante todo o dia.");
    frases.Add("Que a energia positiva do amanhecer nos motive a enfrentar qualquer desafio. Bom dia, família!");
    frases.Add("Que a harmonia e a união estejam presentes em cada momento deste dia. Bom dia, queridos!");
    frases.Add("Bom dia! Que as boas vibrações nos acompanhem e nos inspirem a conquistar nossos objetivos.");
    frases.Add("Que a alegria de viver se faça presente em cada gesto e palavra. Bom dia, família maravilhosa!");
    frases.Add("Que a luz do dia dissipe qualquer sombra e ilumine nosso caminho. Bom dia, pessoal!");
    frases.Add("Bom dia, amados! Que a felicidade seja a trilha que percorreremos juntos hoje.");
    frases.Add("Que cada sorriso seja multiplicado e cada abraço fortaleça nossos laços. Bom dia, família!");
    frases.Add("Que a gratidão nos guie e a paz nos envolva. Bom dia, queridos!");
    frases.Add("Bom dia! Que este dia seja repleto de realizações e momentos inesquecíveis para todos nós.");
    frases.Add("Que a sabedoria nos acompanhe e a fé nos fortaleça. Bom dia, família abençoada!");
    frases.Add("Que a gentileza e o amor sejam os protagonistas do nosso dia. Bom dia, pessoal!");
    frases.Add("Bom dia, amores da minha vida! Que a jornada de hoje seja repleta de sorrisos e conquistas.");
    frases.Add("Que a força interior de cada um nos conduza a um dia incrível. Bom dia, família querida!");
    frases.Add("Bom dia! Que a positividade nos envolva e que cada desafio seja uma oportunidade de crescimento.");
    frases.Add("Que a alegria de viver esteja presente em cada instante deste dia. Bom dia, queridos!");
	}

  //---------------------------------------------------------------------------------------------------

  private void BotatoGerarFoiClicado(object sender, EventArgs args)
  {
    int indice = Random.Shared.Next(0, frases.Count);
    fraseGerada = frases[indice];
    labelMsg.Text = fraseGerada;

    // Faz o botão compartilhar "Piscar"
    MainThread.BeginInvokeOnMainThread(async () =>
    {
      buttonShare.BackgroundColor = Colors.White;
      buttonShare.TextColor       = Color.FromArgb("#512BD4"); // Roxo MAUI
      await Task.Delay(50);
      buttonShare.BackgroundColor = Color.FromArgb("#512BD4"); // Roxo MAUI
      buttonShare.TextColor       = Colors.White;
      await Task.Delay(50);
      buttonShare.BackgroundColor = Colors.White;
      buttonShare.TextColor       = Color.FromArgb("#512BD4"); // Roxo MAUI
      await Task.Delay(50);
      buttonShare.BackgroundColor = Color.FromArgb("#512BD4"); // Roxo MAUI
      buttonShare.TextColor       = Colors.White;
      await Task.Delay(50);
      buttonShare.BackgroundColor = Colors.White;
      buttonShare.TextColor       = Color.FromArgb("#512BD4"); // Roxo MAUI
      await Task.Delay(50);
      buttonShare.BackgroundColor = Color.FromArgb("#512BD4"); // Roxo MAUI
      buttonShare.TextColor       = Colors.White;
    });
  }

  //---------------------------------------------------------------------------------------------------

  private async void BotatoCompartilharFoiClicado(object sender, EventArgs args)
  {
    if (fraseGerada != null)
    {
      await Share.Default.RequestAsync(new ShareTextRequest
      {
          Text = fraseGerada,
          Title = "Gerador de Frases"
      });
    }
  }

  //---------------------------------------------------------------------------------------------------
}


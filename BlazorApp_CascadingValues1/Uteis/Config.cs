//uma forma de simplificar a passagem de parâmetros é passar um tipo complexo, como uma classe
//pode definir "n" parâmetros e passar somente uma instância e usar apenas um CascadingValue (em MainLayout.razor)

namespace BlazorApp_CascadingValues1.Uteis
{
    public class Config
    {
        public string CorDeFundo { get; set; } = "yellow";

        public string TamanhoFonte { get; set; } = "40px";
    }
}

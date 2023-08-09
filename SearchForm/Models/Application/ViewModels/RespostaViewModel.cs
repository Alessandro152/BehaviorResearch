namespace SearchForm.Models.Application.ViewModels
{
    public abstract class RespostaViewModel
    {
        public int Id { get; protected set; }
        public string Expectativa_A { get; protected set; }
        public string Realidade_A { get; protected set; }
        public string Expectativa_B { get; protected set; }
        public string Realidade_B { get; protected set; }
        public string Expectativa_C { get; protected set; }
        public string Realidade_C { get; protected set; }
        public string Expectativa_D { get; protected set; }
        public string Realidade_D { get; protected set; }
    }
}
using HotelEx.Entities.Exceptions;

namespace HotelEx.Entities
{
    public class Reserva
    {
        public int NumeroQuarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }

        public Reserva()
        {
        }

        public Reserva(
            int numeroQuarto, 
            DateTime dataEntrada, 
            DateTime dataSaida)
        {
            if (dataSaida <= dataEntrada)
            {
                throw new DomainException("A data de saída deve ser posterior à data de entrada.");
            }

            NumeroQuarto = numeroQuarto;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public int Duracao()
        {
            TimeSpan duracao = DataSaida.Subtract(DataEntrada);
            return (int)duracao.TotalDays;
        }

        public void AtualizarDatas(
            DateTime dataEntrada, 
            DateTime dataSaida)
        {
            if (dataEntrada < DateTime.Now || dataSaida < DateTime.Now)
            {
                throw new DomainException("As datas de reserva devem ser futuras.");
            }
            if (dataSaida <= dataEntrada)
            {
                throw new DomainException("A data de saída deve ser posterior à data de entrada.");
            }

            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
        }

        public override string ToString()
        {
            return "Quarto: " 
            + NumeroQuarto 
            + ", Check-in: " 
            + DataEntrada.ToString("dd/MM/yyyy") 
            + ", Check-out: " 
            + DataSaida.ToString("dd/MM/yyyy") 
            + ", Duração: " 
            + Duracao() 
            + " dias";
        }

       
    }
}
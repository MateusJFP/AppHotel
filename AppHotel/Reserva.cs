
namespace AppHotel;

public class Reserva
{
    private string _nomeQuarto = "";
    private int _quantidadeHospedes = 1;
    private DateTime _dataEntrada = DateTime.Today;

    // Tipo de acomodação
    public string NomeQuarto
    {
        get { return _nomeQuarto; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                _nomeQuarto = value;
            else
                throw new ArgumentException("Selecione um quarto.");
        }
    }

    // Quantidade de hóspedes
    public int QuantidadeHospedes
    {
        get { return _quantidadeHospedes; }
        set
        {
            if (value >= 1 && value <= 6)
                _quantidadeHospedes = value;
            else
                throw new ArgumentException(
                    "A quantidade deve ser entre 1 e 6 hóspedes.");
        }
    }

    // Data de entrada
    public DateTime DataEntrada
    {
        get { return _dataEntrada; }
        set
        {
            if (value.Date >= DateTime.Today)
                _dataEntrada = value;
            else
                throw new ArgumentException(
                    "A data de entrada não pode ser anterior a hoje.");
        }
    }
}

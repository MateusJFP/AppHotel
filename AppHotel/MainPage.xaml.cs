
namespace AppHotel;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        CheckInDatePicker.Date = DateTime.Today;
    }

    private void OnGuestsChanged(object? sender, ValueChangedEventArgs e)
    {
        int guests = (int)e.NewValue;

        GuestCountLabel.Text = guests == 1
            ? "1 hóspede"
            : $"{guests} hóspedes";
    }

    private async void OnReserveClicked(object? sender, EventArgs e)
    {
        string room = RoomPicker.SelectedItem?.ToString()
                      ?? "Não selecionado";

        string date = CheckInDatePicker.Date?.ToString("dd/MM/yyyy")
                      ?? "Data não selecionada";

        int guests = (int)GuestStepper.Value;

        await DisplayAlertAsync(
            "Resumo da consulta",
            $"Entrada: {date}\nAcomodação: {room}\nHóspedes: {guests}",
            "OK");
    }

    private async void OnAboutClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobrePage());
    }
}

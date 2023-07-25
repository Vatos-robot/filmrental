using System.Collections.Generic;

public class FilmRental
{
    private static readonly Lazy<FilmRental> lazyInstance = new Lazy<FilmRental>(() => new FilmRental());
    public static FilmRental Instance { get { return lazyInstance.Value; } }
    private IPaymentStrategy _paymentStrategy;
    private List<Film> _films = new List<Film>();

    private FilmRental() 
    {
        _paymentStrategy = new CardPaymentStrategy();
    }

    public void AddFilm(Film film)
    {
        _films.Add(film);
    }

    public void Rent(Film film, double amount)
{

    if (!_films.Contains(film))
    {
        Console.WriteLine("Film indisponible");
        return;
    }

   
    _paymentStrategy.Pay(amount);
}


    // autres méthodes
}

public class Program
{
    public static void Main(string[] args)
    {
        FilmRental rental = FilmRental.Instance;

        Film film = new FilmBuilder()
            .SetTitle("Film 1")
            .SetGenre("Action")
            .SetPrice(10.0)
            .Build();

        rental.AddFilm(film);

        FilmBundle bundle = new FilmBundle();
        bundle.AddFilm(film);
        bundle.AddFilm(new FilmBuilder()
            .SetTitle("Film 2")
            .SetGenre("Drama")
            .SetPrice(8.0)
            .Build());

        rental.AddFilm(new SpecialOffer(bundle) { DiscountPercentage = 20 });

        rental.Rent(film, 10.0);;

      
    }
}

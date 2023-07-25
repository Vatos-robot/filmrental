public class SpecialOffer : Film
{
    private Film _film;
    public double DiscountPercentage { get; set; }

    public SpecialOffer(Film film)
    {
        _film = film;
    }

    public override double Price
    {
        get
        {
            return _film.Price - (_film.Price * DiscountPercentage / 100);
        }
        set
        {
            _film.Price = value;
        }
    }
}


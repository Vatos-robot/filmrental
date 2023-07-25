public class FilmBuilder
{
    private Film _film = new Film();

    public FilmBuilder SetTitle(string title)
    {
        _film.Title = title;
        return this;
    }

    public FilmBuilder SetGenre(string genre)
    {
        _film.Genre = genre;
        return this;
    }

    public FilmBuilder SetPrice(double price)
    {
        _film.Price = price;
        return this;
    }

    public Film Build()
    {
        return _film;
    }
}

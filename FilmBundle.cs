using System.Collections.Generic;
using System.Linq;

public class FilmBundle : Film
{
    private List<Film> _films = new List<Film>();

    public void AddFilm(Film film)
    {
        _films.Add(film);
    }

    public override double Price
    {
        get
        {
            return _films.Sum(f => f.Price);
        }
    }
}

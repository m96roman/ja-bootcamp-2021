using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPlyskaLect5
{
    public class Task1
    {
        /// <summary>
        /// Just for example
        /// Yes We can create - FigureInfo(List<Figure> figures) 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="figures"></param>
        public void FigureInfo<T>(IEnumerable<T> figures) where T : Figure
        {
            if (figures is null || figures.Count() == 0)
            {
                throw new ArgumentNullException(nameof(figures), "Agument can not be a null or an empty");
            }

            foreach (var item in figures)
            {
                item.Draw();
            }
        }

        public void FigureInfo<T>(T figure1, T figure2) where T : Figure
        {
            if (figure1 is null || figure2 is null)
            {
                throw new ArgumentNullException(nameof(figure1), nameof(figure2));
            }

            figure1.Draw();
            figure2.Draw();
        }

    }
}

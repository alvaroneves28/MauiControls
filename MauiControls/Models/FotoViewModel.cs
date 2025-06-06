using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; private set; }

        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() { Nome = "Andrômena", ImagemUrl = "andromeda.webp" },
                new Foto() { Nome = "Via Láctea", ImagemUrl = "via_lactea.jpg" },
                new Foto() { Nome = "Universo", ImagemUrl = "universo.jpg" },
                new Foto() { Nome = "Galáxia", ImagemUrl = "galaxia.jpg" },
                new Foto() { Nome = "Sombrero", ImagemUrl = "sombrero.jfif" },
                new Foto() { Nome = "Andrômena", ImagemUrl = "andromeda.webp" },
                new Foto() { Nome = "Via Láctea", ImagemUrl = "via_lactea.jpg" },
                new Foto() { Nome = "Universo", ImagemUrl = "universo.jpg" },
                new Foto() { Nome = "Galáxia", ImagemUrl = "galaxia.jpg" },
                new Foto() { Nome = "Sombrero", ImagemUrl = "sombrero.jfif" },
                new Foto() { Nome = "Andrômena", ImagemUrl = "andromeda.webp" },
                new Foto() { Nome = "Via Láctea", ImagemUrl = "via_lactea.jpg" },
                new Foto() { Nome = "Universo", ImagemUrl = "universo.jpg" },
                new Foto() { Nome = "Galáxia", ImagemUrl = "galaxia.jpg" },
                new Foto() { Nome = "Sombrero", ImagemUrl = "sombrero.jfif" }
            };
        }
    }
}

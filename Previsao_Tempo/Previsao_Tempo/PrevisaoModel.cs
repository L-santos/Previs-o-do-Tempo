using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Previsao_Tempo
{
    /*Modelo para serialização. Não altere este arquivo!*/
    class PrevisaoModel
    {
        public string cidade { get; set; }
        public Agora agora { get; set; }
        public ObservableCollection<PrevisaoT> previsoes { get; set; }
        public class Agora
        {
            public string data_hora { get; set; }
            public string descricao { get; set; }
            public string temperatura { get; set; }
            public string umidade { get; set; }
            public string visibilidade { get; set; }
            public string vento_velocidade { get; set; }
            public string vento_direcao { get; set; }
            public string pressao { get; set; }
            public string pressao_status { get; set; }
            public string nascer_do_sol { get; set; }
            public string por_do_sol { get; set; }
            public string imagem { get; set; }
        }

        public class PrevisaoT
        {
            public string data { get; set; }
            public string descricao { get; set; }
            public string temperatura_max { get; set; }
            public string temperatura_min { get; set; }
            public string imagem { get; set; }
        }
    }
}

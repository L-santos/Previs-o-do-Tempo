using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using System.ComponentModel;

namespace Previsao_Tempo
{
    class Previsao: INotifyPropertyChanged
    {
        public ObservableCollection<PrevisaoModel.PrevisaoT> previsoes;
        public event PropertyChangedEventHandler PropertyChanged;
        private string API_CALL;

        private string descricao;
        private string imagem;
        private string temperatura;
        private string nome;
        private string humidade;
        private string vento_vel;
        private string vento_dir;
        
        public string Nome
        {
            get { return nome; }
            set { nome = value;
            OnPropertyChanged("nome");
            }
        }
        
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value;
                    OnPropertyChanged("descricao");     
                }
        }

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value;
                  OnPropertyChanged("imagem");
            }
        }
       
        public string Temperatura
        {
            get { return temperatura; }
            set { temperatura = value+"°";
            OnPropertyChanged("temperatura");       
            }
        }
       
        public string Humidade
        {
            get { return humidade; }
            set
            {
                humidade = "Umidade: "+value;
                OnPropertyChanged("humidade");
            }
        }

        public string Vento_Dir
        {
            get { return vento_dir; }
            set
            {
                vento_dir = value;
                OnPropertyChanged("vento_dir");
            }
        }

        public string Vento_Vel
        {
            get { return vento_vel; }
            set
            {
                vento_vel = value;
                OnPropertyChanged("vento_vel");
            }
        }
        
        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null)
            {
                handler(this, new PropertyChangedEventArgs(p));
            }
        }
        
        public Previsao()
        {
            previsoes = new ObservableCollection<PrevisaoModel.PrevisaoT>();
           
        }

        async public Task<int> GetDataAsync(string _city, string _state)
        {
            API_CALL = "http://developers.agenciaideias.com.br/tempo/json/" + _city + "-" + _state;
            HttpClient wc = new HttpClient();
            using(wc)
            {
                string response = await wc.GetStringAsync(API_CALL);
                PrevisaoModel PM = (PrevisaoModel)JsonConvert.DeserializeObject<PrevisaoModel>(response);
                this.Descricao = PM.agora.descricao;
                this.Nome = PM.cidade;
                this.Temperatura = PM.agora.temperatura;
                this.Humidade = PM.agora.umidade;
                this.Imagem = PM.agora.imagem;
                this.previsoes = PM.previsoes;
                this.Vento_Vel = PM.agora.vento_velocidade;
                this.Vento_Dir = PM.agora.vento_direcao;
            }
            return this.previsoes.Count;
        }
    }
}
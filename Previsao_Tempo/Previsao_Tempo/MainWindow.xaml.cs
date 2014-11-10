using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Previsao_Tempo
{
    /// <summary>
    /// Previsao do Tempo by Lucas Santos
    /// </summary>
    public partial class MainWindow : Window
    {
        Previsao previsao;
        public MainWindow()
        {
           previsao = new Previsao();
            /*
             * Seta o DataContext da janela para o objeto previsão permitido que as suas propriedades 
             * sejam visiveis aos controles
             */
           this.DataContext = previsao; 
           InitializeComponent();
        }

        //Busca previsão
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            progress.Visibility = System.Windows.Visibility.Visible;
            try
            {
                int x = await previsao.GetDataAsync(txtCidade.Text, txtEstado.Text);
                SearchGrid.Visibility = System.Windows.Visibility.Collapsed;
                ResultGrid.Visibility = System.Windows.Visibility.Visible;
                /*
                 * Seta o DataContext da lista para a coleção de previsões
                 */
                list.ItemsSource = previsao.previsoes;
            }
            catch (System.NullReferenceException)//Nome da cidade não encontrado
            {
                txtErro.Text = "Ocorreu um erro! Verifique o nome da cidade.";
                txtErro.Visibility = System.Windows.Visibility.Visible;
            }
            catch(System.Net.Http.HttpRequestException)//Sem conexão
            {
                txtErro.Text = "Não foi possivel contactar o servidor, verifique a sua conexão com a internet.";
                txtErro.Visibility = System.Windows.Visibility.Visible;
            }
            finally
            {
                //Esconde a barra de progresso
                progress.Visibility = System.Windows.Visibility.Hidden;
            }
            
        }

        //Volta para a tela principal
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            progress.Visibility = System.Windows.Visibility.Hidden;
            SearchGrid.Visibility = System.Windows.Visibility.Visible;
            txtErro.Visibility = System.Windows.Visibility.Collapsed;
            ResultGrid.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}

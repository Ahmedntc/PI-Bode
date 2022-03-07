using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodeOfWarServer;

// Informação pertinente

// exemplo de string de retorno de ListarPartidas()
// "1,Funcionou!,20/02/2022,A\r\n2,Abc,03/03/2022,J\r\n"

namespace Game
{
    #pragma warning disable IDE1006 // Estilos de Nomenclatura
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Estrutura representante de partidas existentes
        /// </summary>
        public struct Match
        {
            public int id;
            public string name;
            public string date;
            public char status;

            public Match( string id, string name, string date, string status)
            {
                this.id = Int32.Parse(id);
                this.name = name;
                this.date = date;
                this.status = status[0];
            }
            
        } Match[] Matches;

        /// <summary>
        /// Procura por partidas de Bodeofwar existentes
        /// </summary>

        private void btnSearch_Click(object sender, EventArgs e)
        {

            /*
             * Estrutura de confições que define o que foi
             * a opção (string opFilter) que foi definida 
             * como filtragem de partidas.
             * A opção vem através de comboFilters.
             * 
             * Indexes  de option filter:
             * 0 - Todos - 'T'
             * 1 - Abertas - 'A'
             * 2 - Jogando - 'J'
             * 3 - Encerradas - 'E'
             */
            
            string opFilter;
            if (cmbFilters.SelectedIndex == 0) {
                opFilter = "T";
            } 
            else if (cmbFilters.SelectedIndex == 1)
            {
                opFilter = "A";
            }
            else if (cmbFilters.SelectedIndex == 2)
            {
                opFilter = "J";
            }
            else if (cmbFilters.SelectedIndex == 3)
            {
                opFilter = "E";
            } else
            {
                opFilter = "T";
            }

            // recebe as partidas
            string ret = Jogo.ListarPartidas(opFilter);
            // MessageBox.Show(ret);

            if (ret.Length < 1) {
                ret = "1,Nenhuma Partida Encontrada,Sem dados,Z\r\n";
            } 

            //string ret = "1,Funcionou!,20/02/2022,A\r\n2,Abc,03/03/2022,J\r\n";// Jogo.ListarPartidas("T");

            // trata possíveis erros
            if (ret.StartsWith("ERRO")) 
            {
                MessageBox.Show("{0}", ret);
                return;
            }

            // formata o retorno
            ret = ret.Replace("\r", "");
            ret = ret.Substring(0, ret.Length - 1);
            string[] formatted = ret.Split('\n');

            // seta a estrutura matches com o retorno
            Matches = new Match[formatted.Length];
            /*
             * Insere as estruturas no array de partidas "Match",
             */
            for(int i = 0; i < formatted.Length; i++) {
                string[] values = formatted[i].Split(',');
                
                Matches[i] = new Match(
                    values[0],
                    values[1],
                    values[2],
                    values[3]
                    );
            }

            // limpa a lista e preenche ela com matches
            lstMatches.Items.Clear();
            foreach ( Match match in Matches)
            {
                string id = match.id.ToString();
                string name = match.name;

        
                // configura o status da partida
                string stat;
                if ( match.status == 'J')
                {
                    stat = "Jogando";
                } 
                else if ( match.status == 'A')
                {
                    stat = "Aberto";
                } 
                else if ( match.status == 'E')
                {
                    stat = "Encerrado";
                }
                else
                {
                    stat = "? ? ? ?";
                }

                string[] row = { id, name, stat };
                new ListViewItem(row);
                lstMatches.Items.Add(new ListViewItem(row));
            }
        }

        private void Client_Load(object sender, EventArgs e)
        {
            lblVersion.Text += Jogo.Versao;
            /* 
             * Tornar painel de visualização de match ivisivel.
             * Ele se tornará visivel após a seleção de uma partida.
             */
            pnlSelected_Match.Visible = false;
        }

        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e) {
            // Seleção de partida
            if (lstMatches.SelectedIndices.Count > 0) {
                int index = lstMatches.SelectedIndices[0];

                /*
                 * O painel torna-se visivel.
                 */
                pnlSelected_Match.Visible = true;
                lblSelected_Match.Text = "Partida " + Matches[index].id;
                lblMatch_Date.Text = "Criação : " + Matches[index].date;
                lblMatch_Name.Text = Matches[index].name;

                switch (Matches[index].status) {
                    case 'J':
                        lblStatus.Text = "Em jogo";
                        break;

                    case 'A':
                        lblStatus.Text = "Disponível";
                        break;

                    case 'E':
                        lblStatus.Text = "Encerrada";
                        break;

                    default:
                        lblStatus.Text = "? ? ? ?";
                        break;
                }


                /*
                 * Listar usuarios da partida selecionada.
                 */
                string jogadores = Jogo.ListarJogadores(Matches[index].id);
                lstPlayers.Items.Clear();
                if (jogadores != "")
                {
                    jogadores = jogadores.Replace("\r", "");
                    jogadores = jogadores.Substring(0, jogadores.Length - 1);
                    string[] Jformatted = jogadores.Split('\n');

                    //MessageBox.Show(jogadores);
                    for (int i = 0;i < Jformatted.Length;i++) {
                        // MessageBox.Show(Jformatted[i]);
                        string[] jogador = Jformatted[i].Split(',');
                        string id = jogador[0].ToString();
                        string name = jogador[1].ToString();
                        string[] row = { id, name};
                        new ListViewItem(row);
                        lstPlayers.Items.Add(new ListViewItem(row));
                    }
                } else
                {
                    string[] row = { "", "Sem Jogadores" };
                    new ListViewItem(row);
                    lstPlayers.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int index = lstMatches.SelectedIndices[0];
            string name = txtUsername.Text;
            string password = txtPassword.Text;

            if (Matches[index].status != 'A')
            {
                MessageBox.Show("A Partida não está disponível");
            } else
            {
                //tratando possíveis erros de nome e senha de partida e usuário antes de requisitar as funções
                if (name == "" || password == "")
                {
                    MessageBox.Show("ERRO:Id ou Senha da partida está vazio");
                    return;
                }

                if (name == "")
                {
                    MessageBox.Show("ERRO: Nome do jogador está vazio");
                    return;
                }

                if (password.Length > 10)
                {
                    MessageBox.Show("ERRO: Senha com mais de 10 caracteres");
                    return;
                }

                if (name.Length > 50)
                {
                    MessageBox.Show("ERRO: Nome com mais de 50 caracteres");
                    return;
                }
                //Variavel armazenando retorno de EntrarPartida
                string retJoin = Jogo.EntrarPartida(Matches[index].id, name, password);

                if (retJoin.StartsWith("ERRO"))
                {
                    MessageBox.Show(retJoin);
                    return;
                }
                else
                {
                    string[] usrId = retJoin.Split(',');
                    MessageBox.Show(usrId[1]);
                }
                /*MessageBox.Show("{0}", retJoin);*/
            }
        }

        private void btnDebugcall_Click(object sender, EventArgs e)
        {
            DebugConsole debug = new DebugConsole();
            btnDebugcall.Enabled = false;
            debug.Show();
        }

        /*
         * Função para a criação da partida.
         */
        private void btnCreateMatch_Click(object sender, EventArgs e) {
            string nome = txtNewMatchName.Text;
            string senha = txtNewMatchPass.Text;
            txtNewMatchName.Text = "";
            txtNewMatchPass.Text = "";

            if (nome != "" && senha != "") {

                // Verifica se nome já está cadastrado.
                // Coloca o filtro em todos, então realiza a procura

                if (nome.Length > 20)
                {
                    MessageBox.Show("ERRO: Nome da partida com mais que 20 caracteres!");
                    return;
                }
                if (senha.Length > 10)
                {
                    MessageBox.Show("ERRO: Senha com mais de 10 caracteres!");
                    return;
                }
                
                cmbFilters.SelectedIndex = 0;
                btnSearch.PerformClick();

                foreach (Match match in Matches)
                {
                    if (match.name == nome)
                    {
                        MessageBox.Show("ERRO: Nome já em uso!");
                        return;
                    }
                }
                //Variavel armazenando retorno de CriarPartida
                string retCreate = Jogo.CriarPartida(nome, senha);

                if (retCreate.StartsWith("ERRO"))
                {
                    MessageBox.Show(retCreate);
                    return;
                }
                else
                {
                    MessageBox.Show(retCreate);
                    MessageBox.Show("Partida " + nome + " Criada!");
                }
            } else
            {
                MessageBox.Show("Erro: Nome ou senha não podem ser nulos!");
            }
        }
    }
}

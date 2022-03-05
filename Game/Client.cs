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
             */
            string opFilter = "";
            if (comboFilters.SelectedItem == "Todos") {
                opFilter = "T";
            } 
            else if (comboFilters.SelectedItem == "Abertas")
            {
                opFilter = "A";
            }
            else if (comboFilters.SelectedItem == "Jogando")
            {
                opFilter = "J";
            }
            else if (comboFilters.SelectedItem == "Encerradas")
            {
                opFilter = "E";
            } else
            {
                opFilter = "T";
            }

            // recebe as partidas
            string ret = Jogo.ListarPartidas(opFilter);
            MessageBox.Show(ret);

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

        private void lstMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seleção de partida
            if (lstMatches.SelectedIndices.Count > 0)
            {
                int index = lstMatches.SelectedIndices[0];

                /*
                 * O painel torna-se visivel.
                 */
                pnlSelected_Match.Visible = true;
                lblSelected_Match.Text = "Partida " + Matches[index].id;
                lblMatch_Date.Text = "Criação : " + Matches[index].date;
                lblMatch_Name.Text = Matches[index].name;
                switch (Matches[index].status)
                {
                    case 'J':
                        lblStatus.Text = "Em jogo";
                        break;

                    case 'A':
                        lblStatus.Text = "Disponível";
                        break;

                    default:
                        lblStatus.Text = "? ? ? ?";
                        break;
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
                //Jogo.EntrarPartida(Matches[index].id, name, password);
            }
            

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void lblMatch_Name_Click(object sender, EventArgs e)
        {

        }

        private void pnlSelected_Match_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

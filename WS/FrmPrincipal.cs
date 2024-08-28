using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS
{
    public partial class FrmPrincipal : Form
    {

        public FrmPrincipal()
        {
            InitializeComponent();

        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            List<Medico> medicosM = medico.Listar();
            List<Medico> medicosT = medico.ListarTarde();
            List<Medico> medicosN = medico.ListarNoite();
            dgvManha.DataSource = medicosM;
            dgvTarde.DataSource = medicosT;
            dgvNoite.DataSource = medicosN;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            string nome = txtNome.Text;
            string horaEntra = mkHoraEntra.Text;
            string horaSaida = mkHoraSai.Text;
            string turno;

            //string EntraSub = hEntra.Substring(0, 5);
            //string SaiSub = hSai.Substring(0, 5);

            

            if (string.IsNullOrEmpty(nome) == true)
            {
                MessageBox.Show("Por Favor Preencha o Nome!", "Campos Vazios", MessageBoxButtons.OK);
            }
            else
            {
                TimeSpan hora, horasai;
                if (TimeSpan.TryParse(horaEntra, out hora) && TimeSpan.TryParse(horaSaida, out horasai))
                {
                    TimeSpan hEntraManha = new TimeSpan(6, 0, 0);
                    TimeSpan hSaiManha = new TimeSpan(12, 0, 0);

                    TimeSpan hEntraTarde = new TimeSpan(12, 1, 0);
                    TimeSpan hSaiTarde = new TimeSpan(17, 0, 0);
                    if (hora >= hEntraManha && horasai <= hSaiManha)
                    {
                        turno = "Manhã";
                        medico.Inserir(nome, horaEntra.ToString(), horaSaida.ToString(), turno);
                        List<Medico> medicos = medico.Listar();
                        dgvManha.DataSource = medicos;
                    }
                    else if (hora >= hEntraTarde && horasai <= hSaiTarde)
                    {
                        turno = "Tarde";
                        medico.Inserir(nome, horaEntra.ToString(), horaSaida.ToString(), turno);
                        List<Medico> medicos = medico.ListarTarde();
                        dgvTarde.DataSource = medicos;
                    }
                    else
                    {
                        turno = "Noite";
                        medico.Inserir(nome, horaEntra.ToString(), horaSaida.ToString(), turno);
                        List<Medico> medicos = medico.ListarNoite();
                        dgvNoite.DataSource = medicos;
                    }
                }
                
            }




        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            string nome = txtNome.Text;
            string horaEntra = mkHoraEntra.Text;
            string horaSaida = mkHoraSai.Text;
            string turno;

            //string EntraSub = hEntra.Substring(0, 5);
            //string SaiSub = hSai.Substring(0, 5);



            if (string.IsNullOrEmpty(nome) == true)
            {
                MessageBox.Show("Por Favor Preencha o Nome!", "Campos Vazios", MessageBoxButtons.OK);
            }
            else
            {
                TimeSpan hora, horasai;
                if (TimeSpan.TryParse(horaEntra, out hora) && TimeSpan.TryParse(horaSaida, out horasai))
                {
                    TimeSpan hEntraManha = new TimeSpan(6, 0, 0);
                    TimeSpan hSaiManha = new TimeSpan(12, 0, 0);

                    TimeSpan hEntraTarde = new TimeSpan(12, 1, 0);
                    TimeSpan hSaiTarde = new TimeSpan(17, 0, 0);
                    if (hora >= hEntraManha && horasai <= hSaiManha)
                    {
                        turno = "Manhã";
                        medico.Inserir(nome, horaEntra.ToString(), horaSaida.ToString(), turno);
                        List<Medico> medicos = medico.Listar();
                        dgvManha.DataSource = medicos;
                    }
                    else if (hora >= hEntraTarde && horasai <= hSaiTarde)
                    {
                        turno = "Tarde";
                        medico.Inserir(nome, horaEntra.ToString(), horaSaida.ToString(), turno);
                        List<Medico> medicos = medico.ListarTarde();
                        dgvTarde.DataSource = medicos;
                    }
                    else
                    {
                        turno = "Noite";
                        medico.Inserir(nome, horaEntra.ToString(), horaSaida.ToString(), turno);
                        List<Medico> medicos = medico.ListarNoite();
                        dgvNoite.DataSource = medicos;
                    }
                }

            }

        }
        }

        //private void dgvManha_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = this.dgvManha.Rows[e.RowIndex];
        //        this.dgvManha.Rows[e.RowIndex].Selected = true;
        //        txtId.Text = row.Cells[0].Value.ToString();
        //        txtNome.Text = row.Cells[1].Value.ToString();
        //        dtHoraEntra.Text = row.Cells[2].Value.ToString();
        //        dtpHoraSaida.Text = row.Cells[3].Value.ToString();
        //    }
        //}

        //private void dgvTarde_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = this.dgvManha.Rows[e.RowIndex];
        //        this.dgvManha.Rows[e.RowIndex].Selected = true;
        //        txtId.Text = row.Cells[0].Value.ToString();
        //        txtNome.Text = row.Cells[1].Value.ToString();
        //        dtHoraEntra.Text = row.Cells[2].Value.ToString();
        //        dtpHoraSaida.Text = row.Cells[3].Value.ToString();
        //    }
        //}

        //private void dgvNoite_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = this.dgvManha.Rows[e.RowIndex];
        //        this.dgvManha.Rows[e.RowIndex].Selected = true;
        //        txtId.Text = row.Cells[0].Value.ToString();
        //        txtNome.Text = row.Cells[1].Value.ToString();
        //        dtHoraEntra.Text = row.Cells[2].Value.ToString();
        //        dtpHoraSaida.Text = row.Cells[3].Value.ToString();
        //    }
        //}
    
}

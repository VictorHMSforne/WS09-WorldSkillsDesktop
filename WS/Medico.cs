using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WS
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string HoraEntra { get; set; }
        public string HoraSai { get; set; }
        public string Turno { get; set; }

        SqlConnection con = new SqlConnection ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\WS\\WS\\WS\\DbConsultorio.mdf;Integrated Security=True");

        public List<Medico> Listar()
        {
                List<Medico> li = new List<Medico>();
                con.Open();
                string sql = "SELECT * FROM Medicos WHERE Turno='Manhã'";
                SqlCommand cmd = new SqlCommand(sql, con);
                
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Medico medico = new Medico();
                    medico.Id = (int)rd["Id"];
                    medico.Nome = rd["Nome"].ToString();
                    medico.HoraEntra = rd["HoraEntra"].ToString();
                    medico.HoraSai = rd["HoraSai"].ToString();
                    medico.Turno = rd["Turno"].ToString();
                    li.Add(medico);
                }
                con.Close();
                return li;     
        }
        public List<Medico> ListarTarde()
        {
            List<Medico> li = new List<Medico>();
            con.Open();
            string sql = "SELECT * FROM Medicos WHERE Turno='Tarde'";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Medico medico = new Medico();
                medico.Id = (int)rd["Id"];
                medico.Nome = rd["Nome"].ToString();
                medico.HoraEntra = rd["HoraEntra"].ToString();
                medico.HoraSai = rd["HoraSai"].ToString();
                medico.Turno = rd["Turno"].ToString();
                li.Add(medico);
            }
            con.Close();
            return li;
        }
        public List<Medico> ListarNoite()
        {
            List<Medico> li = new List<Medico>();
            con.Open();
            string sql = "SELECT * FROM Medicos WHERE Turno='Noite'";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Medico medico = new Medico();
                medico.Id = (int)rd["Id"];
                medico.Nome = rd["Nome"].ToString();
                medico.HoraEntra = rd["HoraEntra"].ToString();
                medico.HoraSai = rd["HoraSai"].ToString();
                medico.Turno = rd["Turno"].ToString();
                li.Add(medico);
            }
            con.Close();
            return li;
        }

        public void Inserir(string nome,string hEntra,string hSai, string turno)
        {
            try
            {
                string sql = "INSERT INTO Medicos(Nome,HoraEntra,HoraSai,Turno) VALUES('" + nome + "','" + hEntra + "','" + hSai + "','" + turno + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void Atualizar(int id, string nome, string hEntra, string hSai, string turno)
        {
            try
            {
                string sql = "UPDATE Medicos SET Nome='" + nome + "',HoraEntra='" + hEntra + "',HoraSai='" + hSai + "',Turno='" + turno + "'WHERE Id='" + id + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

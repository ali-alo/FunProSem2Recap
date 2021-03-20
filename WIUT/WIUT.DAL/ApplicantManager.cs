using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIUT.DAL
{
    class ApplicantManager
    {
        public void Create(Applicant a)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $@"
INSERT INTO Applicant (Name, Surname, Address, DoB, MaritalStatus, PassportNo, CourseId) 
VALUES('{a.Name}', '{a.Surname}', '{a.Address}', '{a.DoB:yyyy-MM-dd}', '{a.MaritalStatus}', '{a.PassportNo}', {a.Course.Id})";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void Update(Applicant a)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $@"
UPDATE Applicant SET 
    Name = '{a.Name}', 
    Surname = '{a.Surname}', 
    Address = '{a.Address}', 
    DoB = '{a.DoB:yyyy-MM-dd}', 
    MaritalStatus = '{a.MaritalStatus}', 
    PassportNo = '{a.PassportNo}', 
    CourseId = {a.Course.Id}
WHERE Id = {a.Id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public void Delete(int id)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $"DELETE FROM Applicant Where Id={id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public Applicant GetById(int id)
        {
            var connection = new SqlCeConnection("");
            try
            {
                var sql = $@"
Select Id, Name, Surname, Address, DoB, MaritalStatus, PassportNo, CourseId
FROM Applicant
WHERE Id = {id}";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    var a = GetFromReader(reader);
                    return a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            // if we are here - something went wrong
            return null;
        }

        public List<Applicant> GetAll()
        {
            var connection = new SqlCeConnection("");
            var result = new List<Applicant>();
            try
            {
                var sql = "SELECT Id, Name, Surname, Address, DoB, MaritalStatus, PassportNo, CourseId FROM Applicant";
                var command = new SqlCeCommand(sql, connection);
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var a = GetFromReader(reader);
                    result.Add(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return result;
        }

        private Applicant GetFromReader(SqlCeDataReader reader)
        {
            var a = new Applicant
            {
                Id = Convert.ToInt32(reader.GetValue(0)),
                Name = reader.GetValue(1).ToString(),
                Surname = reader.GetValue(2).ToString(),
                Address = reader.GetValue(3).ToString(),
                DoB = Convert.ToDateTime(reader.GetValue(4)),
                MaritalStatus = reader.GetValue(5).ToString(),
                PassportNo = reader.GetValue(6).ToString(),
                Course = new CourseManager().GetById(Convert.ToInt32(reader.GetValue(7)))
            };

            return a;
        }
    }
}

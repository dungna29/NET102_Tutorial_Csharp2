using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BAI_2._8_DocGhiDoiTuong
{
    class StudentService
    {
        private FileStream _fs;
        private BinaryFormatter _bf;
        private string _path;
        private List<Student> _lsStudents;
        public StudentService()
        {
            _lsStudents = new List<Student>();
        }
        public List<Student> GetFakeLstStudents()
        {
            return new List<Student>()
            {
                new Student(1, "PH00532", "A"),
                new Student(2, "PH00533", "B"),
                new Student(3, "PH00534", "C"),
            };
        }

        public string GhiFile(List<Student> lstStudents, string path)
        {
            try
            {
                _fs = new FileStream(path, FileMode.Create);
                _bf = new BinaryFormatter();
                _bf.Serialize(_fs, lstStudents);
                _fs.Close();
                return "Ghi file thành công";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return "Ghi file thất bại";
        }
        public List<Student> DocFile(string path)
        {
            try
            {
                _lsStudents = new List<Student>();
                _fs = new FileStream(path, FileMode.Open);
                _bf = new BinaryFormatter();
                var data = _bf.Deserialize(_fs);
                _lsStudents = data as List<Student>;
                _fs.Close();
                return _lsStudents;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
    }
}

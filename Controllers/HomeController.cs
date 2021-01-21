using EFCoreAsp2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreAsp2.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController:Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public string Index()
        {
            //查询所有学生信息
            IEnumerable<Student> model = _studentRepository.GetAllStudents();
            var count= model.Count().ToString();
            return $"There is {count} students.";
        }





    }
}

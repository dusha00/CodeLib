using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /// <summary>
    /// 把类的耦合都放在了Facade类中
    /// 三层架构就是这样的一个例子
    /// </summary>
    public class RegistrationFacade
    {
        private readonly RegisterCourse _registerCourse;
        private readonly NotifyStudent _notifyStudent;

        public RegistrationFacade(RegisterCourse registerCourse, NotifyStudent notifyStudent)
        {
            _registerCourse = registerCourse;
            _notifyStudent = notifyStudent;
        }

        public bool RegisterCourse(string courseName, string studentName)
        {
            if (!_registerCourse.CheckAvailable(courseName))
            {
                return false;
            }
            return _notifyStudent.Notify(studentName);
        }

    }


    #region 子系统
    // 相当于子系统A
    public class RegisterCourse
    {
        public bool CheckAvailable(string courseName)
        {
            Console.WriteLine("正在验证课程 {0}是否人数已满", courseName);
            return true;
        }
    }

    // 相当于子系统B
    public class NotifyStudent
    {
        public bool Notify(string studentName)
        {
            Console.WriteLine("正在向{0}发生通知", studentName);
            return true;
        }
    }
    #endregion
}

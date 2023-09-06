using ClassMembershipApplication.FieldValidators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembershipApplication.View
{
    public interface IView
    {
        void RunView();
        IFieldValidator fieldValidator { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembershipApplication.FieldValidators
{
    public delegate bool FieldValidatorDel(int fieldIndex, string fieldValue, string[] fieldArray, out string fieldInvalidMessage);
    public interface IFieldValidator
    {
        void InitialiseValidatorDelegates();
        string[] FieldArray { get; }
        FieldValidatorDel FieldValidatorDel { get; }
    }
}
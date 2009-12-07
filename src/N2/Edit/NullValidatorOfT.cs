﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace N2.Edit
{
    /// <summary>
    /// Doesn't return any validation errors.
    /// </summary>
    /// <typeparam name="T">The type of model object (ignored)</typeparam>
    public class NullValidator<T> : IValidator<T>
    {
        #region IValidator<T> Members

        public ICollection<ValidationError> Validate(T contentItem)
        {
            return new List<ValidationError>();
        }

        #endregion
    }
}

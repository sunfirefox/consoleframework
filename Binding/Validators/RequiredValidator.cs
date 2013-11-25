﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binding.Validators
{
    /**
 * Validator checks the value is not null or empty (if value string).
 *
 * User: igor.kostromin
 * Date: 26.06.13
 * Time: 22:04
 */
public class RequiredValidator : IBindingValidator<Object> {
    public ValidationResult validate(Object value) {
        if (value == null || value is String && ((String) value).Length == 0)
            return new ValidationResult(false, "Value is required");
        return new ValidationResult(true);
    }
}

}

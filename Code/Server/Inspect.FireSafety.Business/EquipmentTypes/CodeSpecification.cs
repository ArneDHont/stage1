using Inspect.FireSafety.Shared;
using Inspect.Framework.Data;
using System;
using System.Linq.Expressions;

namespace Inspect.FireSafety.Business.EquipmentTypes
{
    public class CodeArraySpecification : IEntitySpecification<EquipmentType>
    {
        public CodeArraySpecification(params string[] code)
        {
            Code = code ?? new string[] { };
        }

        public string[] Code { get; private set; }

        public Expression<Func<EquipmentType, bool>> ToExpression()
        {
            var specification = EntitySpecification.Default<EquipmentType>(Code.Length == 0);
            foreach (var code in Code)
            {
                specification = specification.Or(new CodeSpecification(code));
            }
            return specification.ToExpression();
        }
    }

    public class CodeSpecification : IEntitySpecification<EquipmentType>
    {
        public CodeSpecification(string code)
        {
            Code = code;
        }

        public string Code { get; private set; }

        public Expression<Func<EquipmentType, bool>> ToExpression()
        {
            return x => x.Code == Code;
        }
    }
}
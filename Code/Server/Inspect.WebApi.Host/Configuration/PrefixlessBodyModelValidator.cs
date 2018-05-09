using System;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;
using System.Web.Http.Validation;

namespace Inspect.WebApi.Host.Configuration
{
    /// <summary>
    /// An implementation of a <see cref="IBodyModelValidator"/> that does not prefex the keys with the name of the parameter (default).
    /// </summary>
    public class PrefixlessBodyModelValidator : IBodyModelValidator
    {
        private readonly IBodyModelValidator mInnerValidator;

        public PrefixlessBodyModelValidator(IBodyModelValidator innerValidator)
        {
            if (innerValidator == null)
            {
                throw new ArgumentNullException("innerValidator");
            }

            mInnerValidator = innerValidator;
        }

        public bool Validate(object model, Type type, ModelMetadataProvider metadataProvider, HttpActionContext actionContext, string keyPrefix)
        {
            // Remove the keyPrefix but otherwise let innerValidator do what it normally does.
            return mInnerValidator.Validate(model, type, metadataProvider, actionContext, String.Empty);
        }
    }
}
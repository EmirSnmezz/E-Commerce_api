﻿using Core.Utilities.Messages.Constants;
using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidations : AbstractValidator<Product>
    {
        public ProductValidations()
        {
            #region Validation Rules For Product Name
            RuleFor(product => product.ProductName).NotEmpty().WithMessage(Messages.ProductNameMustBeNotNull);
            RuleFor(product => product.ProductName).NotNull().WithMessage(Messages.ProductNameMustBeNotNull);
            RuleFor(product => product.ProductName).MinimumLength(2);
            #endregion

            #region Validation Rules For Category Id
            RuleFor(product => product.CategoryID).NotEmpty().WithMessage(Messages.CategoryNameMustBeNotNullOnTheProductDefinition);
            RuleFor(product => product.CategoryID).NotNull().WithMessage(Messages.CategoryNameMustBeNotNullOnTheProductDefinition);
            #endregion

            #region Validation Rules For UnitPrice
            RuleFor(product => product.UnitPrice).NotEmpty().WithMessage(Messages.UnitPriceNotBeNullOnTheProductDefinition);
            RuleFor(product => product.UnitPrice).NotNull().WithMessage(Messages.UnitPriceNotBeNullOnTheProductDefinition);
            #endregion

            #region Validation Rules For UnitsInStock
            RuleFor(product => product.UnitsInStock).NotEmpty().WithMessage(Messages.UnitsInStockNotBeNullOnTheProductDefinition);
            RuleFor(product => product.UnitsInStock).NotNull().WithMessage(Messages.UnitsInStockNotBeNullOnTheProductDefinition);
            #endregion
        }
    }
}

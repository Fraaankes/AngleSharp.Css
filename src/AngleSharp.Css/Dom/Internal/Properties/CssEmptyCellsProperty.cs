﻿namespace AngleSharp.Css.Dom
{
    using AngleSharp.Css;
    using AngleSharp.Css.Converters;
    using static ValueConverters;

    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/empty-cells
    /// Gets if borders and backgrounds should be drawn like
    /// in a normal cells. Otherwise no border or backgrounds
    /// should be drawn.
    /// </summary>
    sealed class CssEmptyCellsProperty : CssProperty
    {
        #region Fields

        private static readonly IValueConverter StyleConverter = Or(EmptyCellsConverter, AssignInitial(true));

        #endregion

        #region ctor

        internal CssEmptyCellsProperty()
            : base(PropertyNames.EmptyCells, PropertyFlags.Inherited)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return StyleConverter; }
        }

        #endregion
    }
}
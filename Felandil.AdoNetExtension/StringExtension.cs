namespace Felandil.AdoNetExtension
{
  using System;

  /// <summary>
  /// The string extension.
  /// </summary>
  public static class StringExtension
  {
    #region Public Methods and Operators

    /// <summary>
    /// The to type.
    /// </summary>
    /// <param name="input">
    /// The input.
    /// </param>
    /// <typeparam name="TOut">
    /// Output type
    /// </typeparam>
    /// <returns>
    /// The <see cref="TOut"/>.
    /// </returns>
    public static TOut ToType<TOut>(this string input)
    {
      var type = typeof(TOut);

      object value = null;

      if (type == typeof(bool))
      {
        value = bool.Parse(input);
      }

      if (type == typeof(byte))
      {
        value = byte.Parse(input);
      }

      if (type == typeof(char))
      {
        value = char.Parse(input);
      }

      if (type == typeof(DateTime))
      {
        value = DateTime.Parse(input);
      }

      if (type == typeof(decimal))
      {
        value = decimal.Parse(input);
      }

      if (type == typeof(double))
      {
        value = double.Parse(input);
      }

      if (type == typeof(float))
      {
        value = float.Parse(input);
      }

      if (type == typeof(Guid))
      {
        value = Guid.Parse(input);
      }

      if (type == typeof(short))
      {
        value = short.Parse(input);
      }

      if (type == typeof(int))
      {
        value = int.Parse(input);
      }

      if (type == typeof(long))
      {
        value = long.Parse(input);
      }

      if (type == typeof(string))
      {
        value = input;
      }

      if (type == typeof(bool?))
      {
        value = bool.Parse(input);
      }

      if (type == typeof(byte?))
      {
        value = byte.Parse(input);
      }

      if (type == typeof(char?))
      {
        value = char.Parse(input);
      }

      if (type == typeof(DateTime?))
      {
        value = DateTime.Parse(input);
      }

      if (type == typeof(decimal?))
      {
        value = decimal.Parse(input);
      }

      if (type == typeof(double?))
      {
        value = double.Parse(input);
      }

      if (type == typeof(float?))
      {
        value = float.Parse(input);
      }

      if (type == typeof(Guid?))
      {
        value = Guid.Parse(input);
      }

      if (type == typeof(short?))
      {
        value = short.Parse(input);
      }

      if (type == typeof(int?))
      {
        value = int.Parse(input);
      }

      if (type == typeof(long?))
      {
        value = long.Parse(input);
      }

      return (TOut)value;
    }

    #endregion
  }
}